using BO;
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
    public partial class FormRDV : Form
    {
        #region Attributs

        private String _modeAnimal;

        public String ModeAnimal
        {
            get { return _modeAnimal; }
            set { _modeAnimal = value; }
        }

        public Client ClientCourant
        {
            get { return (Client)CBox_Client.SelectedItem; }
        }

        #endregion

        public FormRDV()
        {
            InitializeComponent();
        }

        private void FormRDV_Load(object sender, EventArgs e)
        {
            CBox_Client.DataSource = MgtClient.GetClients();
            CBox_Client.DisplayMember = "nomPrenom";

            CBox_Animal.DataSource = MgtAnimal.GetAnimalsByClient(((Client)CBox_Client.SelectedItem).codeClient);
            CBox_Animal.DisplayMember = "Nom";

            CBox_Vétérinaire.DataSource = MgtVeterinaire.GetVeterinaires();
            CBox_Vétérinaire.DisplayMember = "NomVeto";
            CBox_Vétérinaire.SelectedIndex = -1;

            DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByDate(DTPicker_Date.Value);

            #region Mise en Forme de la Grille

            AffichageUrgences();

            DataGrid_RDV.DefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_RDV.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_RDV.Columns["dateRDV"].DefaultCellStyle.Format = "HH:mm";

            DataGrid_RDV.Columns["Urgence"].Visible = false;

            DataGrid_RDV.Columns["dateRDV"].DisplayIndex = 0;
            DataGrid_RDV.Columns["Client"].DisplayIndex = 1;
            DataGrid_RDV.Columns["Animal"].DisplayIndex = 2;
            DataGrid_RDV.Columns["Vétérinaire"].DisplayIndex = 3;

            #endregion
        }

        #region Panel Clients/Animaux

        /// <summary>
        /// Affichage des RDV du Client sélectionné en fonction des autres champs
        /// </summary>
        private void CBox_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBox_Client.SelectedItem != null)
            {
                CBox_Animal.DataSource = MgtAnimal.GetAnimalsByClient(((Client)CBox_Client.SelectedItem).codeClient);
                AffichageUrgences();
            }

            // Cas où un Client est renseigné, sans Vétérinaire spécifique
            if ((CBox_Client.SelectedItem != null) && (CBox_Vétérinaire.SelectedItem == null))
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByClient(((Client)CBox_Client.SelectedItem).codeClient, DTPicker_Date.Value);
                AffichageUrgences();
            }
            // Cas où un Client est renseigné, avec Vétérinaire spécifique
            else if ((CBox_Client.SelectedItem != null) && (CBox_Vétérinaire.SelectedItem != null))
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaire.SelectedItem).codeVeto, DTPicker_Date.Value);
                AffichageUrgences();
            }

            // Si on vide les Clients mais qu'il y a un vétérinaire de selectionné
            if (CBox_Client.SelectedItem == null && CBox_Vétérinaire.SelectedItem != null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaire.SelectedItem).codeVeto, DTPicker_Date.Value);
                AffichageUrgences();
            }
            // Si on vide les Clients et qu'il n'y a pas de vétérinaire selectionné
            else if (CBox_Client.SelectedItem == null && CBox_Vétérinaire.SelectedItem == null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByDate(DTPicker_Date.Value);
                AffichageUrgences();
            }
        }

        /// <summary>
        /// Ouverture du formulaire d'ajout de Client
        /// </summary>
        private void PBox_AddClient_Click(object sender, EventArgs e)
        {
            FormClients frm = new FormClients();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
        }

        /// <summary>
        /// Ouverture du formulaire d'ajout d'animal pour le Client sélectionné
        /// </summary>
        private void PBox_AddAnimal_Click(object sender, EventArgs e)
        {
            ModeAnimal = "Ajout";
            FormAnimaux frm = new FormAnimaux(null, this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
            frm.Disposed += Recharger;
        }

        /// <summary>
        /// Vide le contenu du Panel Clients/Animaux
        /// </summary>
        private void Label_Vider_Client_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CBox_Client.SelectedIndex = -1;
            CBox_Animal.SelectedIndex = -1;
        }

        /// <summary>
        /// Rechargement de la Liste des Animaux du Client sélectionné
        /// </summary>
        private void Recharger(object sender, EventArgs arg)
        {
            CBox_Animal.DataSource = MgtAnimal.GetAnimalsByClient(ClientCourant.codeClient);
        }

        #endregion

        #region Panel Vétérinaires

        /// <summary>
        /// Affichage des RDV du Vétérinaire sélectionné en fonction des autres champs
        /// </summary>
        private void CBox_Vétérinaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si un vétérinaire est selectionné, on affiche son Agenda du Jour
            if (CBox_Vétérinaire.SelectedItem != null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaire.SelectedItem).codeVeto, DTPicker_Date.Value);
                AffichageUrgences();
            }
            // Si on vide le Vétérinaire et qu'il a un Client sélectionné
            else if (CBox_Vétérinaire.SelectedItem == null && CBox_Client.SelectedItem != null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByClient(((Client)CBox_Client.SelectedItem).codeClient, DTPicker_Date.Value);
                AffichageUrgences();
            }
            // Si on vide le Vétérinaire et qu'il n'y a pas de Client sélectionné
            else if (CBox_Vétérinaire.SelectedItem == null && CBox_Client.SelectedItem == null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByDate(DTPicker_Date.Value);
                AffichageUrgences();
            }
        }

        /// <summary>
        /// Vide le contenu du Panel Vétérinaire
        /// </summary>
        private void Label_Vider_Véto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CBox_Vétérinaire.SelectedIndex = -1;
        }

        #endregion

        #region Panel Date

        /// <summary>
        /// Affichage des RDV de la date sélectionnée en fonction des autres champs
        /// </summary>
        private void DTPicker_Date_ValueChanged(object sender, EventArgs e)
        {
            // Si seule la Date est renseignée
            if ((CBox_Client.SelectedItem == null) && (CBox_Animal.SelectedItem == null) && (CBox_Vétérinaire.SelectedItem == null))
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByDate(DTPicker_Date.Value);
                AffichageUrgences();
            }
            // Si un Vétérinaire est renseigné
            else if (CBox_Vétérinaire.SelectedItem != null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaire.SelectedItem).codeVeto, DTPicker_Date.Value);
                AffichageUrgences();
            }
            // Si un Client est renseigné, sans Vétérinaire spécifique
            else if ((CBox_Client.SelectedItem != null) && (CBox_Vétérinaire.SelectedItem == null))
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByClient(((Client)CBox_Client.SelectedItem).codeClient, DTPicker_Date.Value);
                AffichageUrgences();
            }
        }

        #endregion

        #region Gestion des Boutons

        /// <summary>
        /// Ajout du Rendez-Vous dans la Base de Données
        /// </summary>
        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            // Affectation de la Date et de l'heure
            DateTime laDate = DTPicker_Date.Value;
            TimeSpan heuresMinutes = new TimeSpan(int.Parse(CBox_Heure.SelectedItem.ToString()), int.Parse(CBox_Minute.SelectedItem.ToString()), 0);
            laDate = laDate.Date + heuresMinutes;

            // Vérification de la disponibilité du Vétérinaire à cette heure-ci
            if (!MgtRendezVous.CheckRendezVous(((Veterinaire)CBox_Vétérinaire.SelectedItem).codeVeto, laDate))
            {
                MessageBox.Show("Ce Vétérinaire a déjà un Rendez-Vous à cette heure-là !");
            }
            else
            {
                RendezVous newRDV = new RendezVous(laDate, ((Client)CBox_Client.SelectedItem).nomClient, ((Client)CBox_Client.SelectedItem).prenomClient, ((Animal)CBox_Animal.SelectedItem).codeAnimal, ((Animal)CBox_Animal.SelectedItem).nomAnimal, ((Veterinaire)CBox_Vétérinaire.SelectedItem).nomVeto);
                MgtRendezVous.CreateRDV(newRDV);
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaire.SelectedItem).codeVeto, DTPicker_Date.Value);
                AffichageUrgences();
            }
        }

        /// <summary>
        /// Ajout du Rendez-Vous dans la Base de Données avec la Date et l'Heure actuelles
        /// </summary>
        private void BTN_Urgence_Click(object sender, EventArgs e)
        {
            RendezVous newRDV = new RendezVous(DateTime.Now, ((Client)CBox_Client.SelectedItem).nomClient, ((Client)CBox_Client.SelectedItem).prenomClient, ((Animal)CBox_Animal.SelectedItem).codeAnimal, ((Animal)CBox_Animal.SelectedItem).nomAnimal, ((Veterinaire)CBox_Vétérinaire.SelectedItem).nomVeto, true);
            MgtRendezVous.CreateRDV(newRDV);
            DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaire.SelectedItem).codeVeto, DTPicker_Date.Value);
            AffichageUrgences();
        }

        /// <summary>
        /// Tentative de Suppression du Rendez-Vous
        /// </summary>
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            if (((RendezVous)DataGrid_RDV.CurrentRow.DataBoundItem).dateRDV.Date >= DateTime.Now.Date)
            {
                try
                {
                    MgtRendezVous.DeleteRDV((RendezVous)DataGrid_RDV.CurrentRow.DataBoundItem);
                    DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByDate(DTPicker_Date.Value);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur lors de la Suppression du RDV...");
                }
            }
            else
            {
                MessageBox.Show("Le Rendez-Vous est déjà passé, impossible de le supprimer.");
            }
            AffichageUrgences();
        }

        /// <summary>
        /// Annulation et Fermeture
        /// </summary>
        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Gestion de l'Affichage

        /// <summary>
        /// Affichage en rouge des RDV ayant été placés en Urgence
        /// </summary>
        private void AffichageUrgences()
        {
            foreach (DataGridViewRow row in DataGrid_RDV.Rows)
            {
                if (bool.Parse(row.Cells[4].Value.ToString()) == true)
                    row.DefaultCellStyle.ForeColor = Color.Red;
                else
                    row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        #endregion
    }
}
