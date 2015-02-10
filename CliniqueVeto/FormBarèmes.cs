using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BO;

namespace CliniqueVeto
{
    public partial class FormBarèmes : Form
    {
        public FormBarèmes()
        {
            InitializeComponent();
        }

        private void FormBarèmes_Load(object sender, EventArgs e)
        {
            CBox_TypeTarif.SelectedIndex = 0;
            // Chargement de la grille
            DataGrid_Barèmes.DataSource = MgtBareme.GetBaremes();
        }

        private void BTN_MiseAJour_Click(object sender, EventArgs e)
        {
            if (BTN_MiseAJour.Text == "Mettre à Jour")
            {
                BTN_MiseAJour.Text = "Valider";
                BTN_Annuler.Visible = true;
                Label_Acte.Visible = true;
                Label_Tarif.Visible = true;
                TBox_Type.Visible = true;
                Tbox_Libelle.Visible = true;
                CBox_TypeTarif.Visible = true;
                // Remplir les TEXTBOX TypeActe et Libellé par l'élément sélectionné

            }
            else if (BTN_MiseAJour.Text == "Valider")
            {
                // Validation, changement de l'archive de l'élément selectionné et création du nouveau
                Reset();
            }
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            BTN_MiseAJour.Text = "Mettre à Jour";
            BTN_Annuler.Visible = false;
            Label_Acte.Visible = false;
            Label_Tarif.Visible = false;
            TBox_Type.Visible = false;
            Tbox_Libelle.Visible = false;
            CBox_TypeTarif.Visible = false;
            CBox_TypeTarif.SelectedIndex = 0;
            Label_Fixe.Visible = false;
            TBox_TarifFixe.Visible = false;
            Label_Maxi.Visible = false;
            Label_Mini.Visible = false;
            TBox_TarifMaxi.Visible = false;
            TBox_TarifMini.Visible = false;
        }

    }
}
