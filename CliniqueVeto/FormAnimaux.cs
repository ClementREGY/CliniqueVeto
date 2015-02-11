using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BLL;

namespace CliniqueVeto
{
    public partial class FormAnimaux : Form
    {
        #region Attributs et Propriétés

        private FormClients frmClients = null;
        private FormRDV frmRDV = null;
        private Client ClientCourant = null;

        #endregion
        
        public FormAnimaux(FormClients frm = null, FormRDV frmR = null)
        {
            InitializeComponent();
            if (frm != null)
                frmClients = frm;
            else if (frmR != null)
                frmRDV = frmR;
        }

        private void FormAnimaux_Load(object sender, EventArgs e)
        {
            if (frmClients != null)
                ClientCourant = frmClients.ClientCourant;
            else if (frmRDV != null)
                ClientCourant = frmRDV.ClientCourant;

            TBox_Code.Enabled = false;
            TBox_Client.Enabled = false;
            CBox_Espèce.DataSource = MgtAnimal.GetEspeces();
            CBox_Race.DataSource = MgtAnimal.GetRaces(CBox_Espèce.Items[0].ToString());
            TBox_Client.Text = ClientCourant.nomPrenom;

            // Affichage en fonction du mode
            if (frmClients.ModeAnimal == "Ajout")
            {
                CBox_Genre.SelectedIndex = 0;
                CBox_Espèce.SelectedIndex = 0;
                CBox_Race.SelectedItem = 0;
                BTN_Dossier.Enabled = false;
            }
            else if (frmClients.ModeAnimal == "Modification")
            {
                CBox_Espèce.SelectedIndex = CBox_Espèce.FindStringExact(frmClients.AnimalCourant.espece);
                CBox_Race.DataSource = MgtAnimal.GetRaces(frmClients.AnimalCourant.espece);
                AfficherAnimalCourant();
            }
        }

        #region Gestion de l'Affichage

        /// <summary>
        /// Remplissage des champs avec les données de l'animal courant
        /// </summary>
        private void AfficherAnimalCourant()
        {
            TBox_Code.Text = frmClients.AnimalCourant.codeAnimal.ToString();
            TBox_Nom.Text = frmClients.AnimalCourant.nomAnimal;

            if (frmClients.AnimalCourant.sexe.StartsWith("M"))
                CBox_Genre.SelectedIndex = 1;
            else if (frmClients.AnimalCourant.sexe.StartsWith("F"))
                CBox_Genre.SelectedIndex = 0;
            else if (frmClients.AnimalCourant.sexe.StartsWith("H"))
                CBox_Genre.SelectedIndex = 2;

            TBox_Couleur.Text = frmClients.AnimalCourant.couleur;
            TBox_Tatouage.Text = frmClients.AnimalCourant.tatouage;
            CBox_Race.SelectedValue = frmClients.AnimalCourant.race;
            CBox_Espèce.SelectedValue = frmClients.AnimalCourant.espece;
        }

        /// <summary>
        /// Affichage des races correspondantes à l'espèce selectionnée
        /// </summary>
        private void CBox_Espèce_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBox_Race.DataSource = MgtAnimal.GetRaces(CBox_Espèce.SelectedValue.ToString());
        }

        /// <summary>
        /// Réinitialisation des Champs de saisie et réactivation des boutons
        /// </summary>
        private void Reset()
        {
            Panel_GestionAnimaux.Enabled = true;
            TBox_Nom.Clear();
            TBox_Code.Clear();
            TBox_Couleur.Clear();
            TBox_Client.Clear();
            TBox_Tatouage.Clear();
            CBox_Espèce.SelectedItem = 0;
            CBox_Genre.SelectedItem = 0;
            CBox_Race.SelectedItem = 0;
        }

        #endregion

        #region Gestion des Boutons

        /// <summary>
        /// Ouverture de la fenêtre de Dossier Médical en passant l'animal courant
        /// </summary>
        private void BTN_Dossier_Click(object sender, EventArgs e)
        {
            FormDossierMédical frm = new FormDossierMédical(frmClients.AnimalCourant.codeAnimal);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
        }

        /// <summary>
        /// Vérifie que tous les champs ont été remplis, si oui, en fonction du mode, ajout ou modification de l'animal
        /// </summary>
        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBox_Nom.Text.Trim()))
            {
                errorSaisie.SetError(TBox_Nom, "Veuillez saisir un Nom.");
            }
            else
            {
                if (String.IsNullOrEmpty(TBox_Couleur.Text.Trim()))
                {
                    errorSaisie.SetError(TBox_Couleur, "Veuillez saisir une Couleur.");
                }
                else
                {
                    if (String.IsNullOrEmpty(CBox_Espèce.Text.Trim()))
                    {
                        errorSaisie.SetError(CBox_Espèce, "Veuillez sélectionner une espèce.");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(CBox_Race.Text.Trim()))
                        {
                            errorSaisie.SetError(CBox_Race, "Veuillez sélectionner une race.");
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(CBox_Genre.Text.Trim()))
                            {
                                errorSaisie.SetError(CBox_Race, "Veuillez sélectionner un genre.");
                            }
                            else
                            {
                                Client client = new Client(frmClients.ClientCourant.nomClient, frmClients.ClientCourant.prenomClient);

                                if (frmClients.ModeAnimal == "Ajout")
                                {
                                    Animal newAnimal = new Animal(new Guid(), TBox_Nom.Text, CBox_Genre.Text[0].ToString(), CBox_Race.Text.ToString(),
                                    CBox_Espèce.Text.ToString(), ClientCourant.codeClient, false, TBox_Couleur.Text, TBox_Tatouage.Text, null);
                                    MgtAnimal.CreateAnimal(newAnimal, client);
                                    this.Close();
                                }
                                else if (frmClients.ModeAnimal == "Modification")
                                {
                                    Animal newAnimal = new Animal(frmClients.AnimalCourant.codeAnimal, TBox_Nom.Text, CBox_Genre.Text[0].ToString(), CBox_Race.Text.ToString(),
                                    CBox_Espèce.Text.ToString(), ClientCourant.codeClient, false, TBox_Couleur.Text, TBox_Tatouage.Text, null);
                                    MgtAnimal.UpdateAnimal(newAnimal);
                                    this.Close();
                                }

                                Reset();
                            }

                        }
                    }
                }
            }
        }

        /// <summary>
        /// Annulation, fermeture de la fenêtre
        /// </summary>
        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
