﻿using BLL;
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
    public partial class FormFactures_Règlement : Form
    {
        #region Attributs et Propriétés

        Guid _codeFacture;

        public Guid CodeFacture
        {
            get { return _codeFacture; }
            set { _codeFacture = value; }
        }

        public Facture FactureCourante
        {
            get { return MgtFacture.GetFacture(_codeFacture); }
        }

        #endregion

        public FormFactures_Règlement()
        {
            InitializeComponent();
        }

        private void FormFactures_Règlement_Load(object sender, EventArgs e)
        {
            DataGrid_Factures.DataSource = MgtFacture.GetFacturesImpayees();
            DataGrid_Factures.Columns["dateFacture"].DefaultCellStyle.Format = "dd/MM/yyyy";
            DataGrid_Factures.Columns["totalFacture"].DefaultCellStyle.Format = "0.00 €";
            DataGrid_Factures.Columns["nomClient"].DisplayIndex = 1;
            DataGrid_Factures.Columns["totalFacture"].Width = 60;
            DataGrid_Factures.Columns["nomAnimal"].Width = 100;
        }

        #region Gestion de l'Affichage

        /// <summary>
        /// Récupération du Code de la Facture selectionnée
        /// </summary>
        private void DataGrid_Factures_SelectionChanged(object sender, EventArgs e)
        {
            CodeFacture = ((Facture)DataGrid_Factures.CurrentRow.DataBoundItem).numFacture;
        }

        #endregion

        #region Gestion des Boutons

        /// <summary>
        /// Ouvre la fenêtre d'affichage de Facture en passant en paramètre le numéro de la facture correspondante
        /// </summary>
        private void BTN_Visualiser_Click(object sender, EventArgs e)
        {
            FormFactures_Afficher frm = new FormFactures_Afficher(CodeFacture);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.BringToFront();
        }

        /// <summary>
        /// Met la Facture à l'état Imprimée dans la Base de Données
        /// </summary>
        private void BTN_Régler_Click(object sender, EventArgs e)
        {
            if (MgtFacture.UpdateFacturePayee(CodeFacture))
            {
                MessageBox.Show("Facture Réglée !");
                DataGrid_Factures.DataSource = MgtFacture.GetFacturesImpayees();
            }
        }

        #endregion
    }
}
