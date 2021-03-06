﻿using BO;
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
            TBox_User.Text = "BOSAPIN";
            TBox_Password.Text = "PIN";
        }

        /// <summary>
        /// Vérifie que tous les champs ont été remplis, si c'est le cas, authentification
        /// </summary>
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
                    // Si le login est authentifié
                    if (MgtLogin.Authentifier(loginSaisie))
                    {
                        Veterinaire VetoConnecté = MgtVeterinaire.GetVeterinaireConnecté(TBox_User.Text, TBox_Password.Text);
                        // Enregistrement de la personne connectée et affichage
                        FormPrincipale frm = new FormPrincipale(VetoConnecté);
                        frm.Show();
                        frm.BringToFront();
                        this.Hide();
                        frm.Disposed += AppliClose;
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

        private void AppliClose(object sender, EventArgs arg)
        {
            this.Close();
        }
    }
}
