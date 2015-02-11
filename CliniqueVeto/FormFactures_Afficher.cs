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
    public partial class FormFactures_Afficher : Form
    {
        #region Attributs et Propriétés

        Guid _codeFacture;
        Facture _factureCourante;
        Consultation _consultation;

        public Guid CodeFacture
        {
            get { return _codeFacture; }
            set { _codeFacture = value; }
        }

        public Facture FactureCourante
        {
            get { return MgtFacture.GetFacture(_codeFacture); }
        }

        public Consultation Consultation
        {
            get { return MgtConsultation.GetConsultation(_factureCourante.codeConsult); }
        }

        #endregion

        public FormFactures_Afficher(Guid codeFacture)
        {
            InitializeComponent();
            CodeFacture = codeFacture;
        }

        private void FormFactures_Afficher_Load(object sender, EventArgs e)
        {
            _factureCourante = MgtFacture.GetFacture(CodeFacture);

            richTBox_Facture.TabStop = false;
            richTBox_Facture.ReadOnly = true;
            richTBox_Facture.BackColor = Color.White;
            richTBox_Facture.Cursor = Cursors.Arrow;

            AfficherEntête();
            AfficherConsultation();
            AfficherTotal();
            AfficherSignature();
        }

        #region Gestion de l'Affichage

        /// <summary>
        /// Affichage de l'entête de la Facture : Nom du Client
        /// </summary>
        private void AfficherEntête()
        {
            richTBox_Facture.AppendText(" ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText("Mr/Mme ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(_factureCourante.nomClient.ToUpper(), Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);
            richTBox_Facture.AppendText(" ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText("Au ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(_factureCourante.adresseClient, Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);
            richTBox_Facture.AppendText("---------------------------------------------", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);
        }

        /// <summary>
        /// Affichage de la Consultation concernée : Date, Nom du Vétérinaire, Nom de l'Animal
        /// </summary>
        private void AfficherConsultation()
        {
            _consultation = Consultation;
            richTBox_Facture.AppendText(" ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText("Pour la consultation du ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(_factureCourante.dateConsult.ToString("dd/MM/yyyy"), Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(" à ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(_factureCourante.dateConsult.ToString("HH:mm"), Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);
            richTBox_Facture.AppendText(" ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText("Effectuée par ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(_factureCourante.nomVeto, Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);
            richTBox_Facture.AppendText(" ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText("Pour l'animal ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(_factureCourante.nomAnimal, Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);
            richTBox_Facture.AppendText("---------------------------------------------", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);

            AfficherDétails();
        }

        /// <summary>
        /// Affichage des détails des Actes facturés : Code Groupement, Libellé et Prix
        /// </summary>
        private void AfficherDétails()
        {
            List<Acte> _actes = MgtActe.GetActesByConsultation(_consultation.codeConsultation);

            foreach (Acte unActe in _actes)
            {
                String[] détailActe = new String[3];

                détailActe[0] = String.Format(" - Groupement {0}", unActe.codeGroupement);
                détailActe[1] = String.Format("   {0}", unActe.libelle);
                détailActe[2] = String.Format("                                   | {0}€", unActe.prix.ToString("N2"));

                richTBox_Facture.AppendText(Environment.NewLine);
                richTBox_Facture.AppendText(détailActe[0], Color.Black, 10, false, false, false, true);
                richTBox_Facture.AppendText(détailActe[1], Color.Black, 10, false, false, false, true);
                richTBox_Facture.AppendText(Environment.NewLine);
                richTBox_Facture.AppendText(détailActe[2], Color.Black, 10, false, false, false, true);
                richTBox_Facture.AppendText(Environment.NewLine);
            }
        }

        /// <summary>
        /// Affichage du montant total à payer
        /// </summary>
        private void AfficherTotal()
        {
            richTBox_Facture.AppendText(Environment.NewLine);
            richTBox_Facture.AppendText("---------------------------------------------", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);
            richTBox_Facture.AppendText("                 ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText("TOTAL NET À PAYER | ", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(_factureCourante.totalFacture.ToString("N2"), Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText("€", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);
        }

        /// <summary>
        /// Affichage de la Signature de la clinique
        /// </summary>
        private void AfficherSignature()
        {
            richTBox_Facture.AppendText(Environment.NewLine);
            richTBox_Facture.AppendText(Environment.NewLine);
            richTBox_Facture.AppendText("                Clinique Vétérinaire Ani’Forme", Color.Black, 10, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);
            richTBox_Facture.AppendText("                 Représentée par : M. BOSAPIN Edmond", Color.Black, 8, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);
            richTBox_Facture.AppendText("                             Directeur Administratif", Color.Black, 8, false, false, false, true);
            richTBox_Facture.AppendText(Environment.NewLine);
        }

        #endregion
    }
}
