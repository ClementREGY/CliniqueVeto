using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BO;

namespace CliniqueVeto
{
    public partial class FormRelance_VaccinSelection : Form
    {
        #region Attributs et Propriétés

        public RelanceVaccins RelanceCourante
        {
            get { return (RelanceVaccins)DataGrid_Relance.CurrentRow.DataBoundItem; }
        }

        #endregion

        public FormRelance_VaccinSelection()
        {
            InitializeComponent();
        }

        private void FormRelance_Load(object sender, EventArgs e)
        {
            DataGrid_Relance.DefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_Relance.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_Relance.DataSource = MgtRelanceVaccins.GetRelances();
        }

        #region Gestion des Boutons

        /// <summary>
        /// Ouverture de la fenêtre du Courrier de Relance
        /// </summary>
        private void BTN_Générer_Click(object sender, EventArgs e)
        {
            FormRelance_VaccinCourrier frm = new FormRelance_VaccinCourrier(this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
        }

        #endregion
    }
}
