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
    public partial class FormStock : Form
    {
        public Vaccin VaccinCourant
        {
            get
            {
                return (Vaccin)DataGrid_Vaccins.CurrentRow.DataBoundItem;
            }
        }

        public FormStock()
        {
            InitializeComponent();
        }

        private void BTN_MiseAJour_Click(object sender, EventArgs e)
        {
            if (BTN_MiseAJour.Text == "Mettre à Jour")
            {
                Label_Fournisseur.Visible = true;
                CBox_Fournisseurs.Visible = true;
                Label_Nombre.Visible = true;
                TBox_Nombre.Visible = true;
                BTN_MiseAJour.Text = "Valider";
            }
            else if (BTN_MiseAJour.Text == "Valider")
            {
                Label_Fournisseur.Visible = false;
                CBox_Fournisseurs.Visible = false;
                Label_Nombre.Visible = false;
                TBox_Nombre.Visible = false;
                BTN_MiseAJour.Text = "Mettre à Jour";
            }
        }



        private void FormStock_Load(object sender, EventArgs e)
        {
            DataGrid_Vaccins.DefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_Vaccins.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            try
            {
                DataGrid_Vaccins.DataSource = MgtVaccin.GetVaccins();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void DataGrid_Vaccins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TBox_Nombre.Text = VaccinCourant.quantiteStock.ToString();
        }
    }
}
