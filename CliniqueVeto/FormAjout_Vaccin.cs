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
    public partial class FormAjout_Vaccin : Form
    {
        #region Attributs et Propriétés

        private String _nom;
        private Decimal _fixe, _mini, _maxi;
        private int _quantite, _validite;

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Decimal Fixe
        {
            get { return _fixe; }
            set { _fixe = value; }
        }

        public Decimal Mini
        {
            get { return _mini; }
            set { _mini = value; }
        }

        public Decimal Maxi
        {
            get { return _maxi; }
            set { _maxi = value; }
        }

        public int Quantite
        {
            get { return _quantite; }
            set { _quantite = value; }
        }

        public int Validite
        {
            get { return _validite; }
            set { _validite = value; }
        }

        #endregion

        public FormAjout_Vaccin()
        {
            InitializeComponent();
        }

        private void FormAjout_Vaccin_Load(object sender, EventArgs e)
        {
            CBox_TypeTarif.SelectedIndex = 0;
            TBox_TarifFixe.Text = "0,00";
        }

        #region Gestion de l'Affichage

        /// <summary>
        /// Affiche les TextBox en fonction du Type de Tarif choisi
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
                TBox_TarifMini.Text = "0,00";
                TBox_TarifMaxi.Text = "0,00";

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
                TBox_TarifFixe.Text = "0,00";
            }
        }

        /// <summary>
        /// Vide la TextBox lors du Focus
        /// </summary>
        private void TBox_TarifFixe_Enter(object sender, EventArgs e)
        {
            TBox_TarifFixe.Clear();
        }

        /// <summary>
        /// Vide la TextBox lors du Focus
        /// </summary>
        private void TBox_TarifMaxi_Enter(object sender, EventArgs e)
        {
            TBox_TarifMaxi.Clear();
        }

        /// <summary>
        /// Vide la TextBox lors du Focus
        /// </summary>
        private void TBox_TarifMini_Enter(object sender, EventArgs e)
        {
            TBox_TarifMini.Clear();
        }

        #endregion

        #region Gestion des Boutons

        /// <summary>
        /// Vérifie les champs saisis puis créé le nouveau vaccin et le barème correspondant
        /// </summary>
        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBox_Nom.Text.Trim()))
            {
                errorSaisie.SetError(TBox_Nom, "Veuillez saisir un Nom.");
            }
            else
            {
                if (String.IsNullOrEmpty(DUP_Période.Text.Trim()))
                {
                    errorSaisie.SetError(DUP_Période, "Veuillez saisir une Période de Validité.");
                }
                else
                {
                    if (String.IsNullOrEmpty(DUP_Quantité.Text.Trim()))
                    {
                        errorSaisie.SetError(DUP_Quantité, "Veuillez saisir une Quantité.");
                    }
                    else
                    {
                        // Validation et création du nouveau vaccin et du barème correspondant
                        if (CBox_TypeTarif.SelectedIndex == 0)
                        {
                            // Vérification de la validité de la valeur saisie, pas de lettre et pas de 0
                            Decimal parsedValue;
                            if (String.IsNullOrEmpty(TBox_TarifFixe.Text.Trim()))
                            {
                                errorSaisie.SetError(TBox_TarifFixe, "Veuillez saisir un Tarif.");
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

                                    Nom = TBox_Nom.Text;
                                    Validite = int.Parse(DUP_Période.Text);
                                    Quantite = int.Parse(DUP_Quantité.Text);
                                    Fixe = Decimal.Parse(TBox_TarifFixe.Text);
                                    Mini = Decimal.Parse(TBox_TarifMini.Text);
                                    Maxi = Decimal.Parse(TBox_TarifMaxi.Text);

                                    Vaccin newVaccin = new Vaccin(new Guid(), Nom, Quantite, Validite);
                                    Guid vaccinCree =  MgtVaccin.CreateVaccin(newVaccin);

                                    int prochainCodeGroupement = MgtBareme.GetDernierCodeVaccin();

                                    Bareme newBareme = new Bareme(prochainCodeGroupement.ToString(), DateTime.Now.ToString("dd/mm/yy"), "VACC", String.Format("Vaccination {0}", Nom), Fixe, 0, 0, vaccinCree.ToString());
                                    MgtBareme.AddBareme(newBareme);

                                    this.Close();
                                }
                            }
                        }
                        else if (CBox_TypeTarif.SelectedIndex == 1)
                        {
                            Decimal parsedValue;
                            if (String.IsNullOrEmpty(TBox_TarifMaxi.Text.Trim()))
                            {
                                errorSaisie.SetError(TBox_TarifMaxi, "Veuillez saisir un Tarif maximum.");
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
                                        errorSaisie.SetError(TBox_TarifMini, "Veuillez saisir un Tarif minimum.");
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

                                            Nom = TBox_Nom.Text;
                                            Validite = int.Parse(DUP_Période.Text);
                                            Quantite = int.Parse(DUP_Quantité.Text);

                                            Fixe = Decimal.Parse(TBox_TarifFixe.Text);
                                            Mini = Decimal.Parse(TBox_TarifMini.Text);
                                            Maxi = Decimal.Parse(TBox_TarifMaxi.Text);

                                            Vaccin newVaccin = new Vaccin(new Guid(), Nom, Quantite, Validite);
                                            Guid vaccinCree = MgtVaccin.CreateVaccin(newVaccin);

                                            int prochainCodeGroupement = MgtBareme.GetDernierCodeVaccin();

                                            Bareme newBareme = new Bareme(prochainCodeGroupement.ToString(), DateTime.Now.ToString("dd/mm/yy"), "VACC", String.Format("Vaccination {0}", Nom), 0, Mini, Maxi, vaccinCree.ToString());
                                            MgtBareme.AddBareme(newBareme);

                                            this.Close();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion
    }
}
