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
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            CBox_Vétérinaires.DataSource = MgtVeterinaire.GetVeterinaires();
            CBox_Vétérinaires.DisplayMember = "NomVeto";

            DataGrid_Agenda.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaires.SelectedItem).codeVeto, DTPicker_Date.Value);

            // Mise en forme de la DataGridView - Police, Format de l'Heure et Ordre des Colonnes
            DataGrid_Agenda.DefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_Agenda.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);

            DataGrid_Agenda.Columns["dateRDV"].DefaultCellStyle.Format = "HH:mm";

            DataGrid_Agenda.Columns["dateRDV"].DisplayIndex = 0;
            DataGrid_Agenda.Columns["Client"].DisplayIndex = 1;
            DataGrid_Agenda.Columns["Animal"].DisplayIndex = 2;
            DataGrid_Agenda.Columns["Vétérinaire"].DisplayIndex = 3;
        }

        #region Gestion de l'Affichage

        /// <summary>
        /// Affichage de l'Agenda du Vétérinaire sélectionné
        /// </summary>
        private void CBox_Vétérinaires_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGrid_Agenda.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaires.SelectedItem).codeVeto, DTPicker_Date.Value);
        }

        /// <summary>
        /// Affichage de l'Agenda correspondant pour la date sélectionnée
        /// </summary>
        private void DTPicker_Date_ValueChanged(object sender, EventArgs e)
        {
            DataGrid_Agenda.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaires.SelectedItem).codeVeto, DTPicker_Date.Value);
        }

        #endregion

        #region Gestion des Boutons

        /// <summary>
        /// Ouverture de la fenêtre de Dossier Médical en passant l'animal correspondant à la ligne de l'Agenda selectionnée
        /// </summary>
        private void BTN_Dossier_Click(object sender, EventArgs e)
        {
            Guid codeAnimalSelectionné = ((RendezVous)DataGrid_Agenda.CurrentRow.DataBoundItem).codeAnimal;
            FormDossierMédical frm = new FormDossierMédical(codeAnimalSelectionné);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
        }

        /// <summary>
        /// Ouverture de la fenêtre de Consultation en passant l'animal correspondant à la ligne de l'Agenda selectionnée
        /// ainsi que le vétérinaire actuellement connecté.
        /// </summary>
        private void DataGrid_Agenda_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormPrincipale frmPrincipale = this.MdiParent as FormPrincipale;
            Guid animalSelectionne = ((RendezVous)DataGrid_Agenda.CurrentRow.DataBoundItem).codeAnimal;
            FormConsultation frm = new FormConsultation(animalSelectionne, frmPrincipale._vetoConnecté.codeVeto);            
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
            this.Close();
        }

        #endregion
    }
}
