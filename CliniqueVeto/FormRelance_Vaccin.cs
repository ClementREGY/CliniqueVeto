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
        #region Attributs et Propriétés

        private FormRelance frmRelance = null;

        #endregion

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

        #region Gestion de l'Affichage

        /// <summary>
        /// Affichage des données relatives à la Relance concernée
        /// </summary>
        private void textRelance()
        {
            richTBox_Courrier.AppendText("Rappel de Vaccination - ", Color.Black, 15, false, false, true);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.nomVaccin, Color.Black, 15, false, false, true);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Madame, Monsieur ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.nomClient, Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(",", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Il apparaît dans notre Base de Données que le dernier vaccin de votre animal ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.nomAnimal, Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(", effectué le ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.dateVigueur.ToShortDateString() , Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(", avait une durée de validité de ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.periodeValidite.ToString(), Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(" mois.", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("La date d'invalidité arrivant donc à échéance, nous vous invitons à prendre Rendez-Vous prochainement avec notre secrétariat afin d'effectuer un rappel.", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Cordialement,", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Clinique Vétérinaire Ani’Forme.", Color.Black, 12, false, false, false);
        }

        #endregion

        #region Gestion des Boutons

        /// <summary>
        /// Met à Jour l'état de relance dans la Base de Données
        /// </summary>
        private void BTN_EnvoiRelance_Click(object sender, EventArgs e)
        {
            MgtRelance.SetRelanceEnvoye(frmRelance.RelanceCourante);
        }

        #endregion
    }
}
