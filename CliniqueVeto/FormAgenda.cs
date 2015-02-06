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

            DataGrid_Agenda.DefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_Agenda.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_Agenda.Columns["dateRDV"].DefaultCellStyle.Format = "HH:mm";
            DataGrid_Agenda.Columns["dateRDV"].DisplayIndex = 0;
            DataGrid_Agenda.Columns["Client"].DisplayIndex = 1;
            DataGrid_Agenda.Columns["Animal"].DisplayIndex = 2;
            DataGrid_Agenda.Columns["Vétérinaire"].DisplayIndex = 3;
        }

        private void CBox_Vétérinaires_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGrid_Agenda.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaires.SelectedItem).codeVeto, DTPicker_Date.Value);
        }

        private void DTPicker_Date_ValueChanged(object sender, EventArgs e)
        {
            DataGrid_Agenda.DataSource = MgtRendezVous.GetAgendaByVeterinaire(((Veterinaire)CBox_Vétérinaires.SelectedItem).codeVeto, DTPicker_Date.Value);
        }

        #region Gestion des Boutons

        private void BTN_Dossier_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
