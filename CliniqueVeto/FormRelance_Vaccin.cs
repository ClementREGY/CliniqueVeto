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
    public partial class FormRelance_Vaccin : Form
    {
        private FormRelance frmRelance = null;

        public FormRelance_Vaccin(FormRelance frm)
        {
            InitializeComponent();
            frmRelance = frm;
        }

        private void FormRelance_Vaccin_Load(object sender, EventArgs e)
        {
            richTBox_Courrier.TabStop = false;
            richTBox_Courrier.ReadOnly = true;
            richTBox_Courrier.BackColor = Color.White;
            richTBox_Courrier.Cursor = Cursors.Arrow;

            textRelance();
        }

        private void textRelance()
        {
            richTBox_Courrier.AppendText("Rappel vaccin ", Color.Black, 15, false, false, true);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.nomVaccin, Color.Black, 15, false, false, true);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Madame, Monsieur ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.nomClient, Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(",", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Il apparaît dans notre base de données que le dernier vaccin de/d' ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.nomAnimal, Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(" effectué le ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.dateVigueur.ToShortDateString() , Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(" avait une durée de validité de ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.periodeValidite.ToString(), Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(" mois. La date d'échéance arrivant donc à grand pas, nous vous invitons donc à prendre rendez-vous prochainement avec notre secrétariat afin d'effectuer un rappel.", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Cordialement,", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Clinique Vétérinaire Ani’Forme.", Color.Black, 12, false, false, false);
        }

        private void BTN_EnvoieRelance_Click(object sender, EventArgs e)
        {
            MgtRelance.SetRelanceEnvoye(frmRelance.RelanceCourante);
        }
    }
}
