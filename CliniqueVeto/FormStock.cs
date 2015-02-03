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
    public partial class FormStock : Form
    {
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
    }
}
