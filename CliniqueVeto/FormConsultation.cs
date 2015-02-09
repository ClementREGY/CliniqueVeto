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
        private Guid _codeAnimal, _codeVeto;
        private Animal _animalCourant;
        private Veterinaire _veterinaireCourant;

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

            CBox_Type.DataSource = MgtConsultation.GetTypesActes();
            CBox_Libellé.DataSource = MgtConsultation.GetLibellesActes(CBox_Type.Items[0].ToString());
        }

        private void CBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBox_Libellé.DataSource = MgtConsultation.GetLibellesActes(CBox_Type.SelectedValue.ToString());
        }

        private void CBox_Libellé_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Decimal> listePrix = MgtConsultation.GetTarifsActes(CBox_Libellé.Text);
            TBox_Prix.Text = listePrix.ElementAt(0).ToString();
            TBox_Mini.Text = listePrix.ElementAt(1).ToString();
            TBox_Maxi.Text = listePrix.ElementAt(2).ToString();
        }
    }
}
