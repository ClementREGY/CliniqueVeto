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
    public partial class FormSelection_Animal : Form
    {
        public FormSelection_Animal()
        {
            InitializeComponent();
        }

        private void FormSelection_Animal_Load(object sender, EventArgs e)
        {
            CBox_Client.DataSource = MgtClient.GetClients();
            CBox_Client.DisplayMember = "nomPrenom";

            CBox_Animal.DataSource = MgtAnimal.GetAnimalsByClient(((Client)CBox_Client.SelectedItem).codeClient);
            CBox_Animal.DisplayMember = "Nom";
        }

        #region Gestion Changement de Client

        /// <summary>
        /// Affichage de la liste des Animaux du Client sélectionné
        /// </summary>
        private void CBox_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBox_Client.SelectedItem != null)
            {
                CBox_Animal.DataSource = MgtAnimal.GetAnimalsByClient(((Client)CBox_Client.SelectedItem).codeClient);
            }
        }

        #endregion

        #region Gestion des Boutons

        /// <summary>
        /// Affichage des éléments correspondants aux critères et recherche
        /// </summary>
        private void BTN_Rechercher_Click(object sender, EventArgs e)
        {
            bool isTrouve = false;
            foreach (Animal unAnimal in MgtAnimal.GetAnimals())
            {
                if ((unAnimal.nomAnimal.ToLower().Contains(TBox_Recherche.Text.Trim().ToLower()) || unAnimal.tatouage.ToLower().Contains(TBox_Recherche.Text.Trim().ToLower())) && isTrouve == false)
                {
                    isTrouve = true;
                    Client leClient = MgtClient.GetClient(unAnimal.client);
                    CBox_Client.SelectedIndex = CBox_Client.FindStringExact(leClient.nomPrenom);
                    CBox_Animal.SelectedIndex = CBox_Animal.FindStringExact(unAnimal.ToString());
                }
            }
            if (!isTrouve)
                MessageBox.Show("Aucun Animal ne corespond à vos critères de recherche !");
        }

        /// <summary>
        /// Ouverture de la fenêtre de Dossier Médical correspondant à l'animal sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            FormDossierMédical frm = new FormDossierMédical(((Animal)CBox_Animal.SelectedItem).codeAnimal);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
            this.Close();
        }

        #endregion
    }
}
