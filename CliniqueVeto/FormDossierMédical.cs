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
    public partial class FormDossierMédical : Form
    {
        #region Attributs et Accesseurs

        Guid _codeAnimal;
        List<Consultation> _consultations;

        public Guid CodeAnimal 
        {
            get { return _codeAnimal; }
            set { _codeAnimal = value; }
        }

        public Animal AnimalCourant
        {
            get { return MgtAnimal.GetAnimal(_codeAnimal); }
        }

        #endregion

        public FormDossierMédical(Guid codeAnimal)
        {
            InitializeComponent();
            CodeAnimal = codeAnimal;
        }

        private void FormDossierMédical_Load(object sender, EventArgs e)
        {
            richTBox_Dossier.TabStop = false;
            richTBox_Dossier.ReadOnly = true;
            richTBox_Dossier.BackColor = Color.White;
            richTBox_Dossier.Cursor = Cursors.Arrow;

            _consultations = MgtConsultation.GetConsultationsByAnimal(CodeAnimal);

            AfficherEntête();
            AfficherPropriétaire();
            AfficherConsultations();
        }

        #region Gestion de l'Affichage

        /// <summary>
        /// Affichage de l'entête du Document : Nom de l'animal courant
        /// </summary>
        private void AfficherEntête()
        {
            richTBox_Dossier.AppendText("  ", Color.Navy, 15, false, false, false);
            richTBox_Dossier.AppendText("Dossier Médical de", Color.Navy, 15, false, false, true);
            richTBox_Dossier.AppendText(" :   ", Color.Navy, 15, false, false, false);
            richTBox_Dossier.AppendText(AnimalCourant.nomAnimal, Color.RoyalBlue, 15, false, false, false);
        }

        /// <summary>
        /// Affichage du Propriétaire de l'Animal : Nom du client correspondant à l'animal courant
        /// </summary>
        private void AfficherPropriétaire()
        {
            Client proprietaire = MgtClient.GetClient(AnimalCourant.client);
            richTBox_Dossier.AppendText(Environment.NewLine);
            richTBox_Dossier.AppendText("  ", Color.Navy, 12, false, true, false);
            richTBox_Dossier.AppendText("Propriétaire : ", Color.Navy, 12, false, true, false);
            richTBox_Dossier.AppendText(proprietaire.nomPrenom, Color.RoyalBlue, 12, false, true, false);
            richTBox_Dossier.AppendText(Environment.NewLine);
        }

        /// <summary>
        /// Parcours et Affichage des consultations (Date, Vétérinaire, puis Commentaire)
        /// </summary>
        private void AfficherConsultations()
        {
            foreach (Consultation uneConsult in _consultations)
            {
                Veterinaire veterinaire = MgtVeterinaire.GetVeterinaire(uneConsult.codeVeto);
                richTBox_Dossier.AppendText(" _________________________________________________________________________________________", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText(Environment.NewLine);
                richTBox_Dossier.AppendText("  ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText("- Date : ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText(uneConsult.dateConsultation.Date.ToString("dd/MM/yyyy"), Color.Navy, 12, false, true, false);
                richTBox_Dossier.AppendText("  ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText("- Vétérinaire : ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText(veterinaire.nomVeto, Color.Navy, 12, false, true, false);
                richTBox_Dossier.AppendText(Environment.NewLine);
                AfficherActes(uneConsult);

                richTBox_Dossier.AppendText(Environment.NewLine);
                richTBox_Dossier.AppendText("  ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText("- Commentaire sur la Consultation : ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText(uneConsult.commentaire, Color.Navy, 12, false, true, false);
                richTBox_Dossier.AppendText(Environment.NewLine);
            }
        }

        /// <summary>
        /// Parcours et Affichage des actes de la Consultation (Type, Libellé)
        /// </summary>
        /// <param name="uneConsultation"> Consultation en cours d'affichage </param>
        private void AfficherActes(Consultation uneConsultation)
        {
            int i = 1;
            uneConsultation.actes = MgtActe.GetActesByConsultation(uneConsultation.codeConsultation);

            foreach (Acte unActe in uneConsultation.actes)
            {
                richTBox_Dossier.AppendText(Environment.NewLine);
                richTBox_Dossier.AppendText("   ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText("  - Acte ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText(" : ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText(i.ToString(), Color.Navy, 12, false, true, false);
                richTBox_Dossier.AppendText(Environment.NewLine);

                richTBox_Dossier.AppendText("     ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText("    Type de l'Acte : ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText(unActe.typeActe, Color.Navy, 12, false, true, false);
                richTBox_Dossier.AppendText("   -  ", Color.Black, 12, false, false, false);
                richTBox_Dossier.AppendText(unActe.libelle, Color.Navy, 12, false, true, false);
                richTBox_Dossier.AppendText(Environment.NewLine);

                i++;
            }
        }

        #endregion
    }
}
