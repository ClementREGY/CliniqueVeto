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
    public partial class FormAnimaux : Form
    {
        #region Attributs et Propriétés
        private FormClients frmClients;

        #endregion
        

        public FormAnimaux(FormClients frm)
        {
            InitializeComponent();
            frmClients = frm;
        }

        private void FormAnimaux_Load(object sender, EventArgs e)
        {
            if (frmClients.ModeAnimal == "Ajout")
            {
                CBox_Genre.SelectedIndex = 0;
                CBox_Espèce.SelectedIndex = 0;
            }

            CBox_Espèce.DataSource = MgtAnimal.GetEspeces();
            CBox_Race.DataSource = MgtAnimal.GetRaces(frmClients.AnimalCourant.espece);

        }

        private void CBox_Genre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AfficherAnimalCourant()
        {
            TBox_Client.Text = frmClients.ClientCourant.codeClient.ToString();
            TBox_Code.Text = frmClients.AnimalCourant.codeAnimal.ToString();
            TBox_Nom.Text = frmClients.AnimalCourant.nomAnimal;
            CBox_Genre.SelectedValue = frmClients.AnimalCourant.sexe;
            TBox_Couleur.Text = frmClients.AnimalCourant.couleur;
            CBox_Espèce.SelectedValue = frmClients.AnimalCourant.espece;
            CBox_Race.SelectedValue = frmClients.AnimalCourant.race;
            TBox_Tatouage.Text = frmClients.AnimalCourant.tatouage;
        }
    }
}
