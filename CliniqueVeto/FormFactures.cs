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
    public partial class FormFactures : Form
    {
        private Consultation _consultationCourante;
        private Facture _factureCourante;

        public FormFactures()
        {
            InitializeComponent();
        }

        private void FormFactures_Load(object sender, EventArgs e)
        {
            DataGrid_Factures.DataSource = MgtConsultation.GetConsultations();
            DataGrid_Factures.Columns["nomAnimal"].DisplayIndex = 3;
        }

        private void DataGrid_Factures_SelectionChanged(object sender, EventArgs e)
        {
            _consultationCourante = (Consultation)DataGrid_Factures.CurrentRow.DataBoundItem;
        }

        private void BTN_Créer_Click(object sender, EventArgs e)
        {
            _factureCourante = new Facture(new Guid(), DateTime.Now, 0);
            _factureCourante.dateConsult = _consultationCourante.dateConsultation;
            _factureCourante.nomAnimal = _consultationCourante.nomAnimal;
            _factureCourante.nomVeto = _consultationCourante.nomVeto;

            Guid numFacture = MgtFacture.CreateFacture(_factureCourante);

            DataGrid_Factures.DataSource = MgtConsultation.GetConsultations();
        }
    }
}
