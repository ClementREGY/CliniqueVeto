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

        private void CBox_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBox_Client.SelectedItem != null)
            {
                CBox_Animal.DataSource = MgtAnimal.GetAnimalsByClient(((Client)CBox_Client.SelectedItem).codeClient);
            }
        }

        #endregion

        #region Gestion des Boutons

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
