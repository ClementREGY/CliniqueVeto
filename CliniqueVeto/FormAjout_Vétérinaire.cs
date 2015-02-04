using System;
using BLL;
using BO;
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
    public partial class FormAjout_Vétérinaire : Form
    {
        #region Attributs et Accesseurs

        private String _nom, _prenom, _password;

        public String Nom 
        {
            get { return _nom; }
            set { _nom = value.ToUpper(); } 
        }

        public String Prenom
        {
            get { return _prenom; }
            set
            {
                string prenomSaisi = value;
                string prenomMaj = prenomSaisi[0].ToString().ToUpper() + prenomSaisi.Substring(1).ToLower();
                _prenom = prenomMaj;             
            }
        }

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        #endregion

        public FormAjout_Vétérinaire()
        {
            InitializeComponent();
        }

        #region Validation

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBox_Nom.Text.Trim()))
            {
                errorSaisie.SetError(TBox_Nom, "Veuillez saisir un Nom.");
            }
            else
            {
                if (String.IsNullOrEmpty(TBox_Prénom.Text.Trim()))
                {
                    errorSaisie.SetError(TBox_Prénom, "Veuillez saisir un Prénom.");
                }
                else
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
                                Nom = TBox_Nom.Text;
                                Prenom = TBox_Prénom.Text;
                                Password = TBox_Password.Text;

                                Login newLogin = new Login(Nom, Password);
                                int idNewVeto = MgtLogin.CreateLogin(newLogin);

                                Veterinaire newVeto = new Veterinaire(new Guid(), Nom + " " + Prenom, idNewVeto);
                                MgtVeterinaire.CreateVeterinaire(newVeto);

                                this.Close();
                            }
                        }
                    }
                }
            }

        }

        #endregion
    }
}
