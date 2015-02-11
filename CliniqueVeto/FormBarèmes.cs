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
    public partial class FormBarèmes : Form
    {
        public Bareme BaremeCourant
        {
            get
            {
                return (Bareme)DataGrid_Barèmes.CurrentRow.DataBoundItem;
            }
        }

        public FormBarèmes()
        {
            InitializeComponent();
        }

        private void FormBarèmes_Load(object sender, EventArgs e)
        {
            Reset();
            CBox_TypeTarif.SelectedIndex = 0;
            ActualiserDataGrid();
        }

        #region Gestion de l'Affichage

        // Remplir les TEXTBOX TypeActe et Libellé par l'élément sélectionné
        private void DataGrid_Barèmes_SelectionChanged(object sender, EventArgs e)
        {
            AfficherActeCourant();
        }

        // Chargement de la grille
        private void ActualiserDataGrid()
        {
            DataGrid_Barèmes.DataSource = MgtBareme.GetBaremes();
            DataGrid_Barèmes.Columns["tarifFixe"].DefaultCellStyle.Format = "0.00 €";
            DataGrid_Barèmes.Columns["tarifMini"].DefaultCellStyle.Format = "0.00 €";
            DataGrid_Barèmes.Columns["tarifMaxi"].DefaultCellStyle.Format = "0.00 €";
        }

        private void AfficherActeCourant()
        {
            TBox_Type.Text = DataGrid_Barèmes.CurrentRow.Cells[1].Value.ToString();
            Tbox_Libelle.Text = DataGrid_Barèmes.CurrentRow.Cells[2].Value.ToString();
        }

        /// <summary>
        /// Réinitialise tous les Champs à saisir
        /// </summary>
        private void Reset()
        {
            BTN_MiseAJour.Text = "Mettre à Jour";
            BTN_Annuler.Visible = false;
            Label_Acte.Visible = false;
            Label_Tarif.Visible = false;
            TBox_Type.Visible = false;
            Tbox_Libelle.Visible = false;
            CBox_TypeTarif.Visible = false;
            CBox_TypeTarif.SelectedIndex = 0;
            Label_Fixe.Visible = false;
            TBox_TarifFixe.Visible = false;
            Label_Maxi.Visible = false;
            Label_Mini.Visible = false;
            TBox_TarifMaxi.Visible = false;
            TBox_TarifMini.Visible = false;
        }

        #endregion

        #region Gestion de Boutons

        private void BTN_MiseAJour_Click(object sender, EventArgs e)
        {
            if (BTN_MiseAJour.Text == "Mettre à Jour")
            {
                BTN_MiseAJour.Text = "Valider";
                BTN_Annuler.Visible = true;
                Label_Acte.Visible = true;
                Label_Tarif.Visible = true;
                TBox_Type.Visible = true;
                Tbox_Libelle.Visible = true;
                CBox_TypeTarif.Visible = true;
            }
            else if (BTN_MiseAJour.Text == "Valider")
            {
                // Validation, changement de l'archive de l'élément selectionné et création du nouveau
                if (CBox_TypeTarif.SelectedIndex == 0)
                {
                    if (String.IsNullOrEmpty(TBox_TarifFixe.Text.Trim()))
                    {
                        errorSaisie.SetError(TBox_TarifFixe, "Veuillez saisir un nouveau tarif.");
                    }
                    else
                    {
                        Bareme baremeSET = new Bareme(BaremeCourant.codeGroupement, BaremeCourant.dateVigueur, TBox_Type.Text, Tbox_Libelle.Text, decimal.Parse(TBox_TarifFixe.Text), 0, 0, BaremeCourant.codeVaccin, false);
                        BaremeCourant.dateVigueur = DateTime.Now.ToString();
                        Bareme baremeADD = new Bareme(BaremeCourant.codeGroupement, BaremeCourant.dateVigueur, TBox_Type.Text, Tbox_Libelle.Text, decimal.Parse(TBox_TarifFixe.Text), 0, 0, BaremeCourant.codeVaccin, false);
                        MgtBareme.AddBareme(baremeADD);
                        MgtBareme.SetBaremeArchive(baremeSET);
                    }
                }
                else if (CBox_TypeTarif.SelectedIndex == 1)
                {
                    if (String.IsNullOrEmpty(TBox_TarifMaxi.Text.Trim()))
                    {
                        errorSaisie.SetError(TBox_TarifMaxi, "Veuillez saisir un nouveau tarif maximum.");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(TBox_TarifMini.Text.Trim()))
                        {
                            errorSaisie.SetError(TBox_TarifMini, "Veuillez saisir un nouveau tarif minimum.");
                        }
                        else
                        {
                            Bareme baremeSET = new Bareme(BaremeCourant.codeGroupement, BaremeCourant.dateVigueur, TBox_Type.Text, Tbox_Libelle.Text, 0, decimal.Parse(TBox_TarifMini.Text), decimal.Parse(TBox_TarifMaxi.Text), BaremeCourant.codeVaccin, false);
                            BaremeCourant.dateVigueur = DateTime.Now.ToString();
                            Bareme baremeADD = new Bareme(BaremeCourant.codeGroupement, BaremeCourant.dateVigueur, TBox_Type.Text, Tbox_Libelle.Text, 0, decimal.Parse(TBox_TarifMini.Text), decimal.Parse(TBox_TarifMaxi.Text), BaremeCourant.codeVaccin , false);
                            MgtBareme.AddBareme(baremeADD);
                            MgtBareme.SetBaremeArchive(baremeSET);
                        }
                    }
                }
                ActualiserDataGrid();
                Reset();
            }
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            Reset();
        }

        #endregion

        private void CBox_TypeTarif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBox_TypeTarif.SelectedIndex == 0)
            {
                Label_Fixe.Visible = true;
                TBox_TarifFixe.Visible = true;
                TBox_TarifFixe.Enabled = true;
                Label_Mini.Visible = false;
                Label_Maxi.Visible = false;
                TBox_TarifMini.Visible = false;
                TBox_TarifMaxi.Visible = false;
                TBox_TarifMini.Enabled = false;
                TBox_TarifMaxi.Enabled = false;

            }
            else if (CBox_TypeTarif.SelectedIndex == 1)
            {
                Label_Fixe.Visible = false;
                TBox_TarifFixe.Visible = false;
                TBox_TarifFixe.Enabled = false;
                Label_Mini.Visible = true;
                Label_Maxi.Visible = true;
                TBox_TarifMini.Visible = true;
                TBox_TarifMaxi.Visible = true;
                TBox_TarifMini.Enabled = true;
                TBox_TarifMaxi.Enabled = true;
            }
        }
    }
}
