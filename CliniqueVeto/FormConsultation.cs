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
    public partial class FormConsultation : Form
    {
        #region Attributs

        private Guid _codeAnimal, _codeVeto;
        private Animal _animalCourant;
        private Veterinaire _veterinaireCourant;
        private Consultation _consultationCourante;
        private Bareme _baremeCourant;

        #endregion

        public FormConsultation(Guid codeAnimal, Guid codeVeto)
        {
            InitializeComponent();
            _codeAnimal = codeAnimal;
            _codeVeto = codeVeto;
            _veterinaireCourant = MgtVeterinaire.GetVeterinaire(_codeVeto);
            _animalCourant = MgtAnimal.GetAnimal(_codeAnimal);
        }

        private void FormConsultation_Load(object sender, EventArgs e)
        {
            TBox_Code.Text = _animalCourant.codeAnimal.ToString();
            TBox_Nom.Text = _animalCourant.nomAnimal;
            TBox_Couleur.Text = _animalCourant.couleur;
            TBox_Espèce.Text = _animalCourant.espece;
            TBox_Race.Text = _animalCourant.race;
            TBox_Sexe.Text = _animalCourant.sexe;
            TBox_Tatouage.Text = _animalCourant.tatouage;
            TBox_Vétérinaire.Text = _veterinaireCourant.nomVeto;

            CBox_Type.DataSource = MgtBareme.GetTypesActes();
        }

        #region Gestion de l'Affichage

        private void CBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBox_Libellé.DataSource = MgtBareme.GetLibelleActe(CBox_Type.SelectedValue.ToString());
        }

        private void CBox_Libellé_SelectedIndexChanged(object sender, EventArgs e)
        {
            _baremeCourant = MgtBareme.GetBareme(CBox_Libellé.SelectedValue.ToString());

            TBox_Prix.Text = _baremeCourant.tarifFixe.ToString();
            TBox_Mini.Text = _baremeCourant.tarifMini.ToString();
            TBox_Maxi.Text = _baremeCourant.tarifMaxi.ToString();

            if (TBox_Prix.Text == "0,0000")
                TBox_Prix.Enabled = true;
            else
                TBox_Prix.Enabled = false;
        }

        private void TBox_Prix_Leave(object sender, EventArgs e)
        {
            if ((Decimal.Parse(TBox_Prix.Text) > Decimal.Parse(TBox_Maxi.Text)) || (Decimal.Parse(TBox_Prix.Text) < Decimal.Parse(TBox_Mini.Text)))
            {
                errorSaisie.SetError(TBox_Prix, "Veuillez saisir un Prix entre le Mini et le Maxi !");
                TBox_Prix.Text = "0,0000";      
            }
            else
            {
                errorSaisie.Clear();
                TBox_Prix.Text = string.Format("{0:#,##0.00}", double.Parse(TBox_Prix.Text));
            }
        }

        private void TBox_Prix_Enter(object sender, EventArgs e)
        {
            TBox_Prix.Clear();
        }

        private void CalculTotal()
        {
            Decimal px = 0;
            for (int i = 0; i < DataGrid_Actes.RowCount; i++)
            {
                px += Convert.ToDecimal(DataGrid_Actes.Rows[i].Cells[2].Value);
            }

            TBox_Total.Text = px.ToString();
        }

        #endregion

        #region Gestion des Boutons

        private void BTN_Ajout_Click(object sender, EventArgs e)
        {
            if (BTN_Ajout.Text == "Ajouter un Acte")
            {
                CBox_Type.Enabled = true;
                CBox_Libellé.Enabled = true;
                BTN_Ajout.Text = "Annuler";
                BTN_Enregistrer.Enabled = true;
                if (TBox_Prix.Text == "0,0000")
                    TBox_Prix.Enabled = true;
                else
                    TBox_Prix.Enabled = false;
            }
            else if (BTN_Ajout.Text == "Annuler")
            {
                CBox_Type.Enabled = false;
                CBox_Libellé.Enabled = false;
                TBox_Prix.Enabled = false;
                BTN_Ajout.Text = "Ajouter un Acte";
                BTN_Enregistrer.Enabled = false;
            }
        }

        private void BTN_Enregistrer_Click(object sender, EventArgs e)
        {
            if (DataGrid_Actes.RowCount == 0)
            {
                _consultationCourante = new Consultation(Guid.NewGuid(), DTPicker_Date.Value, _veterinaireCourant.codeVeto, _animalCourant.codeAnimal, 1, null, (TBox_Commentaire.Text == null ? "" : TBox_Commentaire.Text), false);
                Acte nouvelActe = new Acte(_consultationCourante.codeConsultation, Guid.NewGuid(), _baremeCourant.dateVigueur, _baremeCourant.codeGroupement, Decimal.Parse(TBox_Prix.Text), _baremeCourant.typeActe, _baremeCourant.libelle);
                _consultationCourante.actes.Add(nouvelActe);
            }
            else
            {
                Acte nouvelActe = new Acte(_consultationCourante.codeConsultation, Guid.NewGuid(), _baremeCourant.dateVigueur, _baremeCourant.codeGroupement, Decimal.Parse(TBox_Prix.Text), _baremeCourant.typeActe, _baremeCourant.libelle);
                _consultationCourante.actes.Add(nouvelActe);
                DataGrid_Actes.DataSource = null;
            }

            DataGrid_Actes.DataSource = _consultationCourante.actes;
            DataGrid_Actes.Columns["libelle"].DisplayIndex = 0;
            DataGrid_Actes.Columns["codeGroupement"].DisplayIndex = 1;
            DataGrid_Actes.Columns["dateVigueur"].DisplayIndex = 2;
            DataGrid_Actes.Columns["Prix"].DisplayIndex = 3;

            TBox_NbActes.Text = DataGrid_Actes.RowCount.ToString();
            CalculTotal();
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            Acte acteSelect = (Acte)DataGrid_Actes.CurrentRow.DataBoundItem;
            _consultationCourante.actes.Remove(acteSelect);
            DataGrid_Actes.DataSource = null;
            DataGrid_Actes.DataSource = _consultationCourante.actes;
            TBox_NbActes.Text = DataGrid_Actes.RowCount.ToString();
            CalculTotal();
        }

        #endregion
    }
}
