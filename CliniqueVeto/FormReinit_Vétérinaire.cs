using BLL;
using BO;
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
    public partial class FormReinit_Vétérinaire : Form
    {
        #region Attributs et Accesseurs

        private String _password;
        private FormVétérinaires frmVétos;

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        #endregion

        public FormReinit_Vétérinaire(FormVétérinaires frm)
        {
            InitializeComponent();
            frmVétos = frm;
        }

        #region Validation

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBox_Password.Text.Trim()))
            {
                errorSaisie.SetError(TBox_Password, "Veuillez saisir un Mot de Passe.");
            }
            else
            {
                if (String.IsNullOrEmpty(TBox_Password2.Text.Trim()))
                {
                    errorSaisie.SetError(TBox_Password2, "Veuillez ressaisir le Mot de Passe.");
                }
                else
                {
                    if (TBox_Password.Text != TBox_Password2.Text)
                    {
                        errorSaisie.SetError(TBox_Password2, "Les Mots de Passe ne correspondent pas !");
                    }
                    else
                    {
                        Password = TBox_Password.Text;

                        Login ancienLogin = MgtLogin.GetLogin(frmVétos._veterinaireCourant.refLogin);
                        Login newLogin = new Login(ancienLogin.loginUser, Password, ancienLogin.id);
                        MgtLogin.UpdateLogin(newLogin);

                        this.Close();
                    }
                }
            }
        }

        #endregion
    }
}
