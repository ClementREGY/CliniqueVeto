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
using System.Text.RegularExpressions;

namespace CliniqueVeto
{
    public partial class FormBarèmes : Form
    {
        #region Attributs et Accesseurs

        public Bareme BaremeCourant
        {
            get
            {
                return (Bareme)DataGrid_Barèmes.CurrentRow.DataBoundItem;
            }
        }

        #endregion

        public FormBarèmes()
        {
            InitializeComponent();
        }

        private void FormBarèmes_Load(object sender, EventArgs e)
        {
            Reset();
            ActualiserDataGrid();
        }

        #region Gestion de l'Affichage

        /// <summary>
        /// Appel à la fonction d'affichage de l'acte sélectionné
        /// </summary>
        private void DataGrid_Barèmes_SelectionChanged(object sender, EventArgs e)
        {
            AfficherActeCourant();
        }

        /// <summary>
        /// Actualisation et chargement de la DataGrid
        /// </summary>
        private void ActualiserDataGrid()
        {
            DataGrid_Barèmes.DataSource = MgtBareme.GetBaremes();
            DataGrid_Barèmes.Columns["tarifFixe"].DefaultCellStyle.Format = "0.00 €";
            DataGrid_Barèmes.Columns["tarifMini"].DefaultCellStyle.Format = "0.00 €";
            DataGrid_Barèmes.Columns["tarifMaxi"].DefaultCellStyle.Format = "0.00 €";
        }

        /// <summary>
        /// Affiche les informations correspondantes à l'acte sélectionné
        /// </summary>
        private void AfficherActeCourant()
        {
            TBox_Type.Text = DataGrid_Barèmes.CurrentRow.Cells[1].Value.ToString();
            Tbox_Libelle.Text = DataGrid_Barèmes.CurrentRow.Cells[2].Value.ToString();

            if (BTN_MiseAJour.Text == "Valider")
            {
                // Affichage des valeurs correspondantes à la ligne sélectionnée
                if (DataGrid_Barèmes.CurrentRow.Cells[3].Value.ToString() == "0,0000")
                {
                    CBox_TypeTarif.SelectedIndex = 1;
                    TBox_TarifMini.Text = DataGrid_Barèmes.CurrentRow.Cells[4].Value.ToString();
                    TBox_TarifMaxi.Text = DataGrid_Barèmes.CurrentRow.Cells[5].Value.ToString();
                }
                else
                {
                    CBox_TypeTarif.SelectedIndex = 0;
                    Label_Fixe.Visible = true;
                    TBox_TarifFixe.Visible = true;
                    TBox_TarifFixe.Enabled = true;
                    TBox_TarifFixe.Text = DataGrid_Barèmes.CurrentRow.Cells[3].Value.ToString();
                }
            }
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
        
        /// <summary>
        /// Affichage des TextBox en fonction du type de tarif sélectionné
        /// </summary>
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

        /// <summary>
        /// Vide la TextBox lors du focus
        /// </summary>
        private void TBox_TarifFixe_Enter(object sender, EventArgs e)
        {
            TBox_TarifFixe.Clear();
        }

        /// <summary>
        /// Vide la TextBox lors du focus
        /// </summary>
        private void TBox_TarifMaxi_Enter(object sender, EventArgs e)
        {
            TBox_TarifMaxi.Clear();
        }

        /// <summary>
        /// Vide la TextBox lors du focus
        /// </summary>
        private void TBox_TarifMini_Enter(object sender, EventArgs e)
        {
            TBox_TarifMini.Clear();
        }

        #endregion

        #region Gestion des Boutons

        /// <summary>
        /// Met à jour l'ancien barème en l'archivant, puis crée un nouveau barème en vigueur
        /// </summary>
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

                // Affichage des valeurs correspondantes à la ligne sélectionnée
                if (DataGrid_Barèmes.CurrentRow.Cells[3].Value.ToString() == "0,0000")
                {
                    CBox_TypeTarif.SelectedIndex = 1;
                    TBox_TarifMini.Text = DataGrid_Barèmes.CurrentRow.Cells[4].Value.ToString();
                    TBox_TarifMaxi.Text = DataGrid_Barèmes.CurrentRow.Cells[5].Value.ToString();
                }
                else
                {
                    CBox_TypeTarif.SelectedIndex = 0;
                    Label_Fixe.Visible = true;
                    TBox_TarifFixe.Visible = true;
                    TBox_TarifFixe.Enabled = true;
                    TBox_TarifFixe.Text = DataGrid_Barèmes.CurrentRow.Cells[3].Value.ToString();
                }
            }
            else if (BTN_MiseAJour.Text == "Valider")
            {
                // Validation, changement de l'archive de l'élément selectionné et création du nouveau
                if (CBox_TypeTarif.SelectedIndex == 0)
                {
                    // Vérification de la validité de la valeur saisie, pas de lettre et pas de 0
                    Decimal parsedValue;
                    if (String.IsNullOrEmpty(TBox_TarifFixe.Text.Trim()))
                    {
                        errorSaisie.SetError(TBox_TarifFixe, "Veuillez saisir un nouveau tarif.");
                    }
                    else
                    {
                        if (!Decimal.TryParse(TBox_TarifFixe.Text, out parsedValue) || (Decimal.Parse(TBox_TarifFixe.Text) == 0))
                        {
                            errorSaisie.SetError(TBox_TarifFixe, "Veuillez saisir un Prix valide !");
                            TBox_TarifFixe.Text = "0,00";
                        }
                        else
                        {
                            errorSaisie.Clear();
                            Bareme baremeSET = new Bareme(BaremeCourant.codeGroupement, BaremeCourant.dateVigueur, TBox_Type.Text, Tbox_Libelle.Text, Decimal.Parse(TBox_TarifFixe.Text), 0, 0, BaremeCourant.codeVaccin, false);
                            BaremeCourant.dateVigueur = DateTime.Now.ToString("dd/mm/yy");
                            Bareme baremeADD = new Bareme(BaremeCourant.codeGroupement, BaremeCourant.dateVigueur, TBox_Type.Text, Tbox_Libelle.Text, Decimal.Parse(TBox_TarifFixe.Text), 0, 0, BaremeCourant.codeVaccin, false);
                            MgtBareme.AddBareme(baremeADD);
                            MgtBareme.SetBaremeArchive(baremeSET);
                            ActualiserDataGrid();
                            Reset();
                        }
                    }
                }
                else if (CBox_TypeTarif.SelectedIndex == 1)
                {
                    Decimal parsedValue;
                    if (String.IsNullOrEmpty(TBox_TarifMaxi.Text.Trim()))
                    {
                        errorSaisie.SetError(TBox_TarifMaxi, "Veuillez saisir un nouveau tarif maximum.");
                    }
                    else
                    {
                        // Vérification de la validité de la valeur saisie, pas de lettre et pas de 0
                        if (!Decimal.TryParse(TBox_TarifMaxi.Text, out parsedValue) || (Decimal.Parse(TBox_TarifMaxi.Text) == 0))
                        {
                            errorSaisie.SetError(TBox_TarifMaxi, "Veuillez saisir un Prix valide !");
                            TBox_TarifMaxi.Text = "0,00";
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(TBox_TarifMini.Text.Trim()))
                            {
                                errorSaisie.SetError(TBox_TarifMini, "Veuillez saisir un nouveau tarif minimum.");
                            }
                            else
                            {
                                // Vérification de la validité de la valeur saisie, pas de lettre et pas de 0
                                if (!Decimal.TryParse(TBox_TarifMini.Text, out parsedValue) || (Decimal.Parse(TBox_TarifMini.Text) == 0))
                                {
                                    errorSaisie.SetError(TBox_TarifMini, "Veuillez saisir un Prix valide !");
                                    TBox_TarifMini.Text = "0,00";
                                }
                                else
                                {
                                    errorSaisie.Clear();
                                    Bareme baremeSET = new Bareme(BaremeCourant.codeGroupement, BaremeCourant.dateVigueur, TBox_Type.Text, Tbox_Libelle.Text, 0, Decimal.Parse(TBox_TarifMini.Text), Decimal.Parse(TBox_TarifMaxi.Text), BaremeCourant.codeVaccin, false);
                                    BaremeCourant.dateVigueur = DateTime.Now.ToString("dd/mm/yy");
                                    Bareme baremeADD = new Bareme(BaremeCourant.codeGroupement, BaremeCourant.dateVigueur, TBox_Type.Text, Tbox_Libelle.Text, 0, Decimal.Parse(TBox_TarifMini.Text), Decimal.Parse(TBox_TarifMaxi.Text), BaremeCourant.codeVaccin, false);
                                    MgtBareme.AddBareme(baremeADD);
                                    MgtBareme.SetBaremeArchive(baremeSET);
                                    ActualiserDataGrid();
                                    Reset();
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Annulation
        /// </summary>
        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            Reset();
        }

        #endregion
    }
}
