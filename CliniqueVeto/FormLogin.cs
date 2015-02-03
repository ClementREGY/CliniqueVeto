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
            TBox_User.Text = "test";
            TBox_Password.Text = "test";
        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBox_User.Text.Trim()))
            {
                errorSaisie.SetError(TBox_User, "Veuillez saisir un nom d'Utilisateur.");
            }
            else
            {
                if (String.IsNullOrEmpty(TBox_Password.Text.Trim()))
                {
                    errorSaisie.SetError(TBox_Password, "Veuillez saisir un Mot de Passe.");
                }
                else
                {
                    Login loginSaisie = new Login(TBox_User.Text, TBox_Password.Text);
                    if (MgtLogin.Authentifier(loginSaisie))
                    {
                        FormPrincipale frm;
                        frm = new FormPrincipale();
                        frm.Show();
                        frm.BringToFront();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Impossible de se connecter !");
                        TBox_User.Focus();
                        TBox_Password.Clear();
                    }
                }
            }
        }
    }
}
