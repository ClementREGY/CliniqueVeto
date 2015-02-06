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
    public partial class FormDossierMédical : Form
    {
        Guid _codeAnimal;
        Animal _animalCourant;

        public Guid CodeAnimal 
        {
            get { return _codeAnimal; }
            set { _codeAnimal = value; }
        }

        public Animal AnimalCourant
        {
            get { return MgtAnimal.GetAnimal(_codeAnimal); }
        }

        public FormDossierMédical(Guid codeAnimal)
        {
            InitializeComponent();
            CodeAnimal = codeAnimal;
        }

        private void FormDossierMédical_Load(object sender, EventArgs e)
        {
            richTBox_Dossier.TabStop = false;
            richTBox_Dossier.ReadOnly = true;
            richTBox_Dossier.BackColor = Color.White;
            richTBox_Dossier.Cursor = Cursors.Arrow;

            AfficherEntête();
            AfficherPropriétaire();
        }

        private void AfficherEntête()
        {
            richTBox_Dossier.AppendText("  ", Color.Navy, 15, false, false, false);
            richTBox_Dossier.AppendText("Dossier Médical de", Color.Navy, 15, false, false, true);
            richTBox_Dossier.AppendText(" :   ", Color.Navy, 15, false, false, false);
            richTBox_Dossier.AppendText(AnimalCourant.nomAnimal, Color.RoyalBlue, 15, false, false, false);
        }

        private void AfficherPropriétaire()
        {
            Client proprietaire = MgtClient.GetClient(AnimalCourant.client);
            richTBox_Dossier.AppendText(Environment.NewLine);
            richTBox_Dossier.AppendText("  ", Color.Navy, 12, false, true, false);
            richTBox_Dossier.AppendText("Propriétaire : ", Color.Navy, 12, false, true, false);
            richTBox_Dossier.AppendText(proprietaire.nomPrenom, Color.RoyalBlue, 12, false, true, false);
            richTBox_Dossier.AppendText(Environment.NewLine);
        }
    }
}
