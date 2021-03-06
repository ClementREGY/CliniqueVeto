﻿using BO;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliniqueVeto
{
    public partial class FormConsultation : Form
    {
        #region Attributs

        private Guid _codeAnimal, _codeVeto;
        private Animal _animalCourant;
        private Veterinaire _veterinaireCourant;
        private Consultation _consultationCourante = null;
        private Bareme _baremeCourant;

        #endregion

        public FormConsultation(Guid codeAnimal, Guid codeVeto)
        {
            InitializeComponent();
            _codeAnimal = codeAnimal;
            _codeVeto = codeVeto;
            _veterinaireCourant = MgtVeterinaire.GetVeterinaire(_codeVeto);
            _animalCourant = MgtAnimal.GetAnimal(_codeAnimal);
        }

        private void FormConsultation_Load(object sender, EventArgs e)
        {
            TBox_Code.Text = _animalCourant.codeAnimal.ToString();
            TBox_Nom.Text = _animalCourant.nomAnimal;
            TBox_Couleur.Text = _animalCourant.couleur;
            TBox_Espèce.Text = _animalCourant.espece;
            TBox_Race.Text = _animalCourant.race;
            TBox_Sexe.Text = _animalCourant.sexe;
            TBox_Tatouage.Text = _animalCourant.tatouage;
            TBox_Vétérinaire.Text = _veterinaireCourant.nomVeto;

            CBox_Type.DataSource = MgtBareme.GetTypesActes();
        }

        #region Gestion de l'Affichage

        /// <summary>
        /// Affiche le libellé correspondant au Type choisi
        /// </summary>
        private void CBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBox_Libellé.DataSource = MgtBareme.GetLibelleActe(CBox_Type.SelectedValue.ToString());
        }

        /// <summary>
        /// Affiche les tarifs correspondants à l'acte sélectionné
        /// </summary>
        private void CBox_Libellé_SelectedIndexChanged(object sender, EventArgs e)
        {
            _baremeCourant = MgtBareme.GetBareme(CBox_Libellé.SelectedValue.ToString());

            TBox_Prix.Text = _baremeCourant.tarifFixe.ToString("N2");
            TBox_Mini.Text = _baremeCourant.tarifMini.ToString("N2");
            TBox_Maxi.Text = _baremeCourant.tarifMaxi.ToString("N2");

            if (TBox_Prix.Text == "0,00" && BTN_Ajout.Text == "Annuler")
                TBox_Prix.Enabled = true;
            else
                TBox_Prix.Enabled = false;
        }

        /// <summary>
        /// Vérifie lors de la sortie de la TextBox du Prix Fixe, que la valeur saisie est au bon format
        /// et bien située entre le Prix Mini et le Prix Maxi
        /// </summary>
        private void TBox_Prix_Leave(object sender, EventArgs e)
        {
            if ((Decimal.Parse(TBox_Prix.Text) > Decimal.Parse(TBox_Maxi.Text)) || (Decimal.Parse(TBox_Prix.Text) < Decimal.Parse(TBox_Mini.Text)) || (Decimal.Parse(TBox_Prix.Text) == 0))
            {
                errorSaisie.SetError(TBox_Prix, "Veuillez saisir un Prix entre le Mini et le Maxi !");
                TBox_Prix.Text = "0,00";      
            }
            else
            {
                errorSaisie.Clear();
                TBox_Prix.Text = string.Format("{0:#,##0.00}", double.Parse(TBox_Prix.Text));
            }
        }

        /// <summary>
        /// Vide la TextBox de Prix Fixe lors du focus
        /// </summary>
        private void TBox_Prix_Enter(object sender, EventArgs e)
        {
            TBox_Prix.Clear();
        }

        /// <summary>
        /// Calcule et affiche le prix total de la Consultation
        /// </summary>
        private void CalculTotal()
        {
            Decimal px = 0;
            for (int i = 0; i < DataGrid_Actes.RowCount; i++)
            {
                px += Convert.ToDecimal(DataGrid_Actes.Rows[i].Cells[2].Value);
            }

            TBox_Total.Text = px.ToString("N2");
        }

        /// <summary>
        /// Vérifie si un Tatouage a été effectué, si oui, permet la saisie du N° de Tatouage
        /// </summary>
        private void CheckTatouage()
        {
            foreach (Acte unActe in _consultationCourante.actes)
            {
                if (unActe.typeActe == "TATO")
                    TBox_Tatouage.Enabled = true;
                else
                    TBox_Tatouage.Enabled = false;
            }
        }

        #endregion

        #region Gestion des Boutons

        /// <summary>
        /// Ouverture de la fenêtre de Dossier Médical en passant l'animal courant
        /// </summary>
        private void BTN_Dossier_Click(object sender, EventArgs e)
        {
            FormDossierMédical frm = new FormDossierMédical(_animalCourant.codeAnimal);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
        }

        /// <summary>
        /// Met à Jour le commentaire de la consultation et enregistre celle-ci puis ses actes dans la Base de Données
        /// </summary>
        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if (TBox_Tatouage.Enabled && String.IsNullOrWhiteSpace(TBox_Tatouage.Text))
            {
                errorSaisie.SetError(TBox_Tatouage, "Veuillez saisir le N° du Tatouage effectué !");
                TBox_Tatouage.Focus();
            }
            else
            {
                _consultationCourante.commentaire = TBox_Commentaire.Text == null ? null : TBox_Commentaire.Text;
                Guid consultationCreee = MgtConsultation.CreateConsultation(_consultationCourante);

                foreach (Acte unActe in _consultationCourante.actes)
                {
                    unActe.numConsultation = consultationCreee;
                }

                foreach (Acte unActe in _consultationCourante.actes)
                {
                    MgtActe.CreateActe(unActe);
                }

                // Si un tatouage a été effectué et saisi, on met l'animal à jour
                if (TBox_Tatouage.Enabled && !String.IsNullOrWhiteSpace(TBox_Tatouage.Text))
                {
                    MgtAnimal.UpdateTatouage(TBox_Tatouage.Text.Trim(), _animalCourant.codeAnimal);
                }

                // Affichage du montant total de la consultation et fermeture de la fenêtre
                DialogResult result = MessageBox.Show(String.Format("Consultation terminée ! Montant Total : {0}€",TBox_Total.Text), "Enregistré", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Annulation et Fermeture
        /// </summary>
        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Permets la saisie d'un nouvel acte pour la consultation
        /// </summary>
        private void BTN_Ajout_Click(object sender, EventArgs e)
        {
            if (BTN_Ajout.Text == "Ajouter un Acte")
            {
                CBox_Type.Enabled = true;
                CBox_Libellé.Enabled = true;
                BTN_Ajout.Text = "Annuler";
                BTN_Enregistrer.Enabled = true;
                if (TBox_Prix.Text == "0,00")
                    TBox_Prix.Enabled = true;
                else
                    TBox_Prix.Enabled = false;
            }
            else if (BTN_Ajout.Text == "Annuler")
            {
                CBox_Type.Enabled = false;
                CBox_Libellé.Enabled = false;
                TBox_Prix.Enabled = false;
                BTN_Ajout.Text = "Ajouter un Acte";
                BTN_Enregistrer.Enabled = false;
            }
        }

        /// <summary>
        /// Si c'est la consultation n'est pas encore créée, création de la consultation + ajout de l'acte
        /// Sinon, simple ajout de l'acte
        /// </summary>
        private void BTN_Enregistrer_Click(object sender, EventArgs e)
        {
            // Vérifie que le Prix fixe saisi n'est pas égal à 0
            if (TBox_Prix.Text == "0,00")
            {
                errorSaisie.SetError(TBox_Prix, "Veuillez saisir un Prix entre le Mini et le Maxi !");
                TBox_Prix.Text = "0,00";
            }
            else
            {
                errorSaisie.Clear();
                if (_consultationCourante == null)
                {
                    // Si l'erreur n'est pas déclenchée, on peut procéder à l'enregistrement
                    if (errorSaisie.GetError(TBox_Prix) == "")
                    {
                        _consultationCourante = new Consultation(Guid.NewGuid(), DTPicker_Date.Value, _veterinaireCourant.codeVeto, _animalCourant.codeAnimal, 1, null, (TBox_Commentaire.Text == null ? null : TBox_Commentaire.Text), false);
                        Acte nouvelActe = new Acte(_consultationCourante.codeConsultation, Guid.NewGuid(), _baremeCourant.dateVigueur, _baremeCourant.codeGroupement, Decimal.Parse(TBox_Prix.Text), _baremeCourant.typeActe, _baremeCourant.libelle);
                        _consultationCourante.actes.Add(nouvelActe);
                        errorSaisie.Clear();
                    }
                    else
                        errorSaisie.SetError(TBox_Prix, "Veuillez saisir un Prix entre le Mini et le Maxi !");
                }
                else
                {
                    // Si l'erreur n'est pas déclenchée, on peut procéder à l'enregistrement
                    if (errorSaisie.GetError(TBox_Prix) == "")
                    {
                        Acte nouvelActe = new Acte(_consultationCourante.codeConsultation, Guid.NewGuid(), _baremeCourant.dateVigueur, _baremeCourant.codeGroupement, Decimal.Parse(TBox_Prix.Text), _baremeCourant.typeActe, _baremeCourant.libelle);
                        _consultationCourante.actes.Add(nouvelActe);
                        DataGrid_Actes.DataSource = null;
                        errorSaisie.Clear();
                    }
                    else
                        errorSaisie.SetError(TBox_Prix, "Veuillez saisir un Prix entre le Mini et le Maxi !");
                }

                // Si l'erreur n'est pas déclenchée, on peut procéder à la mise à jour des informations
                if (errorSaisie.GetError(TBox_Prix) == "")
                {
                    DataGrid_Actes.DataSource = _consultationCourante.actes;
                    DataGrid_Actes.Columns["libelle"].DisplayIndex = 0;
                    DataGrid_Actes.Columns["codeGroupement"].DisplayIndex = 1;
                    DataGrid_Actes.Columns["dateVigueur"].DisplayIndex = 2;
                    DataGrid_Actes.Columns["Prix"].DisplayIndex = 3;

                    TBox_NbActes.Text = DataGrid_Actes.RowCount.ToString();
                    CalculTotal();
                    CheckTatouage();
                }
            }
        }

        /// <summary>
        /// Suppression de l'acte sélectionné de la liste des actes de la consultation
        /// </summary>
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            if (DataGrid_Actes.RowCount != 0)
            {
                Acte acteSelect = (Acte)DataGrid_Actes.CurrentRow.DataBoundItem;
                _consultationCourante.actes.Remove(acteSelect);
                DataGrid_Actes.DataSource = null;
                DataGrid_Actes.DataSource = _consultationCourante.actes;
                TBox_NbActes.Text = DataGrid_Actes.RowCount.ToString();
                CalculTotal();
                CheckTatouage();
            }
        }

        #endregion
    }
}
