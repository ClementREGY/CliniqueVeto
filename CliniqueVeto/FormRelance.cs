﻿using System;
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
    public partial class FormRelance : Form
    {
        #region Attributs et Propriétés

        public Relance RelanceCourante
        {
            get { return (Relance)DataGrid_Relance.CurrentRow.DataBoundItem; }
        }

        #endregion

        public FormRelance()
        {
            InitializeComponent();
        }

        private void FormRelance_Load(object sender, EventArgs e)
        {
            DataGrid_Relance.DefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_Relance.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_Relance.DataSource = MgtRelance.GetRelances();
        }

        #region Gestion des Boutons

        /// <summary>
        /// Ouverture de la fenêtre du Courrier de Relance
        /// </summary>
        private void BTN_Générer_Click(object sender, EventArgs e)
        {
            FormRelance_Vaccin frm = new FormRelance_Vaccin(this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
        }

        #endregion
    }
}
