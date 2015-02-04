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
    public partial class FormRDV : Form
    {
        public FormRDV()
        {
            InitializeComponent();
        }

        private void FormRDV_Load(object sender, EventArgs e)
        {
            CBox_Client.DataSource = MgtClient.GetClients();
            CBox_Client.DisplayMember = "nomPrenom";

            CBox_Animal.DataSource = MgtAnimal.GetAnimalsByClient(((Client)CBox_Client.SelectedItem).codeClient);
            CBox_Animal.DisplayMember = "Nom";

            CBox_Vétérinaire.DataSource = MgtVeterinaire.GetVeterinaires();
            CBox_Vétérinaire.DisplayMember = "NomVeto";
        }

        private void CBox_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBox_Animal.DataSource = MgtAnimal.GetAnimalsByClient(((Client)CBox_Client.SelectedItem).codeClient);
        }

    }
}
