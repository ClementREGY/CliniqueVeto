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
    public partial class FormFactures_Afficher : Form
    {
        Guid _codeFacture;
        Facture _factureCourante;

        public Guid CodeFacture
        {
            get { return _codeFacture; }
            set { _codeFacture = value; }
        }

        public Facture FactureCourante
        {
            get { return MgtFacture.GetFacture(_codeFacture); }
        }

        public FormFactures_Afficher(Guid codeFacture)
        {
            InitializeComponent();
            CodeFacture = codeFacture;
        }

        private void FormFactures_Afficher_Load(object sender, EventArgs e)
        {
            richTBox_Facture.TabStop = false;
            richTBox_Facture.ReadOnly = true;
            richTBox_Facture.BackColor = Color.White;
            richTBox_Facture.Cursor = Cursors.Arrow;

            AfficherEntête();
        }

        #region Gestion de l'Affichage

        /// <summary>
        /// Affichage de l'entête de la Facture : Nom du Client
        /// </summary>
        private void AfficherEntête()
        {
            richTBox_Facture.AppendText("  ", Color.Black, 15, false, false, false, true);
            richTBox_Facture.AppendText("Facture au Nom de Mr/Mme ", Color.Black, 15, false, false, false, true);
            richTBox_Facture.AppendText(_factureCourante.nomClient, Color.Black, 15, false, false, false, true);
        }

        #endregion
    }
}
