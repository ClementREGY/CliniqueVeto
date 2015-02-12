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
    public partial class FormRelance_FactureCourrier : Form
    {

        #region Attributs et Propriétés

        private FormRelance_FactureSelection frmRelance = null;

        #endregion

        public FormRelance_FactureCourrier(FormRelance_FactureSelection frm)
        {
            InitializeComponent();
            frmRelance = frm;
        }

        /// <summary>
        /// Chargement du contenu de la richTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRelance_FactureCourrier_Load(object sender, EventArgs e)
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
            richTBox_Courrier.AppendText("Rappel de facture impayée - ", Color.Black, 15, false, false, true);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.numFacture.ToString().ToUpper(), Color.Black, 15, false, false, true);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Madame, Monsieur ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.nomClient, Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(",", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Sauf erreur ou omission de notre part, le paiement de la facture n° ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.numFacture.ToString().ToUpper(), Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(" datée du ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.dateFacture.ToShortDateString(), Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(" pour un montant de ", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(frmRelance.RelanceCourante.totalFacture.ToString("N2"), Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(" € ne nous est pas parvenu.", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Nous vous prions donc de bien vouloir procéder à son règlement dans les meilleurs délais.", Color.Black, 12, false, false, false); 
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Si par ailleurs votre paiement venait à nous parvenir avant la réception de la présente, nous vous saurions gré de ne pas en tenir compte.", Color.Black, 12, false, false, false);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText(Environment.NewLine);
            richTBox_Courrier.AppendText("Vous remerciant de faire le nécessaire, et restant à votre entière disposition pour toute question, nous vous prions d'agréer, Madame, Monsieur, l'expression de nos salutations distinguées.", Color.Black, 12, false, false, false);
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
            frmRelance.RelanceCourante.rappelEnvoye = DateTime.Now;
            MgtRelanceFactures.SetRelanceEnvoye(frmRelance.RelanceCourante);
            this.Close();
        }

        #endregion
    }
}
