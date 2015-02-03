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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            Login loginSaisie = new Login(TBox_User.Text, TBox_Password.Text);
            if (MgtLogin.GetLogins().Contains(loginSaisie))
            {
                FormPrincipale frm;
                frm = new FormPrincipale();
                frm.Show();
                frm.BringToFront();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erreur de Connexion !");
            }
        }
    }
}
