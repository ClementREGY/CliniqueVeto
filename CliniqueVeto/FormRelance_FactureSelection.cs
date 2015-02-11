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
    public partial class FormRelance_FactureSelection : Form
    {
        #region Attributs et Propriétés

        public Facture RelanceCourante
        {
            get { return (Facture)DataGrid_Relance.CurrentRow.DataBoundItem; }
        }

        #endregion

        public FormRelance_FactureSelection()
        {
            InitializeComponent();
        }

        private void FormRelance_FactureSelection_Load(object sender, EventArgs e)
        {
            DataGrid_Relance.DefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_Relance.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_Relance.DataSource = MgtRelanceFactures.GetRelances();
        }

        #region Gestion des Boutons

        /// <summary>
        /// Ouverture de la fenêtre du Courrier de Relance
        /// </summary>
        private void BTN_Générer_Click(object sender, EventArgs e)
        {
            FormRelance_FactureCourrier frm = new FormRelance_FactureCourrier(this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
        }

        #endregion
    }
}
