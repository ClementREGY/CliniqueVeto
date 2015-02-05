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

            DataGrid_RDV.DefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_RDV.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_RDV.Columns["dateRDV"].DefaultCellStyle.Format = "HH:mm";
            DataGrid_RDV.Columns["dateRDV"].DisplayIndex = 0;
            DataGrid_RDV.Columns["Client"].DisplayIndex = 1;
            DataGrid_RDV.Columns["Animal"].DisplayIndex = 2;
            DataGrid_RDV.Columns["Vétérinaire"].DisplayIndex = 3;
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Panel Clients/Animaux

        private void CBox_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBox_Client.SelectedItem != null)
            {
                CBox_Animal.DataSource = MgtAnimal.GetAnimalsByClient(((Client)CBox_Client.SelectedItem).codeClient);
            }

            // Cas où un Client est renseigné, sans Vétérinaire spécifique
            if ((CBox_Client.SelectedItem != null) && (CBox_Vétérinaire.SelectedItem == null))
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByClient(((Client)CBox_Client.SelectedItem).codeClient, DTPicker_Date.Value);
            }
            // Cas où un Client est renseigné, avec Vétérinaire spécifique
            else if ((CBox_Client.SelectedItem != null) && (CBox_Vétérinaire.SelectedItem != null))
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaire.SelectedItem).codeVeto, DTPicker_Date.Value);
            }

            // Si on vide les Clients mais qu'il y a un vétérinaire de selectionné
            if (CBox_Client.SelectedItem == null && CBox_Vétérinaire.SelectedItem != null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaire.SelectedItem).codeVeto, DTPicker_Date.Value);
            }
            // Si on vide les Clients et qu'il n'y a pas de vétérinaire selectionné
            else if (CBox_Client.SelectedItem == null && CBox_Vétérinaire.SelectedItem == null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByDate(DTPicker_Date.Value);
            }
        }

        private void PBox_AddClient_Click(object sender, EventArgs e)
        {
            FormClients frm = new FormClients();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
        }

        private void PBox_AddAnimal_Click(object sender, EventArgs e)
        {
            ModeAnimal = "Ajout";
            FormAnimaux frm = new FormAnimaux(null, this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
            frm.Disposed += Recharger;
        }

        private void Label_Vider_Client_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CBox_Client.SelectedIndex = -1;
            CBox_Animal.SelectedIndex = -1;
        }

        private void Recharger(object sender, EventArgs arg)
        {
            CBox_Animal.DataSource = MgtAnimal.GetAnimalsByClient(ClientCourant.codeClient);
        }

        #endregion

        #region Panel Vétérinaires

        private void CBox_Vétérinaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si un vétérinaire est selectionné, on affiche son Agenda du Jour
            if (CBox_Vétérinaire.SelectedItem != null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaire.SelectedItem).codeVeto, DTPicker_Date.Value);
            }
            // Si on vide le Vétérinaire et qu'il a un Client sélectionné
            else if (CBox_Vétérinaire.SelectedItem == null && CBox_Client.SelectedItem != null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByClient(((Client)CBox_Client.SelectedItem).codeClient, DTPicker_Date.Value);
            }
            // Si on vide le Vétérinaire et qu'il n'y a pas de Client sélectionné
            else if (CBox_Vétérinaire.SelectedItem == null && CBox_Client.SelectedItem == null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByDate(DTPicker_Date.Value);
            }
        }

        private void Label_Vider_Véto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CBox_Vétérinaire.SelectedIndex = -1;
        }

        #endregion

        #region Panel Date

        private void DTPicker_Date_ValueChanged(object sender, EventArgs e)
        {
            // Si seule la Date est renseignée
            if ((CBox_Client.SelectedItem == null) && (CBox_Animal.SelectedItem == null) && (CBox_Vétérinaire.SelectedItem == null))
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByDate(DTPicker_Date.Value);
            }
            // Si un Vétérinaire est renseigné
            else if (CBox_Vétérinaire.SelectedItem != null)
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaire.SelectedItem).codeVeto, DTPicker_Date.Value);
            }
            // Si un Client est renseigné, sans Vétérinaire spécifique
            else if ((CBox_Client.SelectedItem != null) && (CBox_Vétérinaire.SelectedItem == null))
            {
                DataGrid_RDV.DataSource = MgtRendezVous.GetAgendaByClient(((Client)CBox_Client.SelectedItem).codeClient, DTPicker_Date.Value);
            }
        }

        #endregion

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            RendezVous newRDV = new RendezVous(DTPicker_Date.Value, ((Client)CBox_Client.SelectedItem).nomClient, ((Client)CBox_Client.SelectedItem).prenomClient, ((Animal)CBox_Animal.SelectedItem).nomAnimal, ((Veterinaire)CBox_Vétérinaire.SelectedItem).nomVeto);
            MgtRendezVous.CreateRDV(newRDV);
        }
    }
}
