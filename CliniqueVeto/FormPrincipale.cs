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
    public partial class FormPrincipale : Form
    {
        #region Attributs

        public Veterinaire _vetoConnecté;

        #endregion

        public FormPrincipale(Veterinaire VetoConnect)
        {
            InitializeComponent();
            _vetoConnecté = VetoConnect;
        }

        #region Vétérinaires

        /// <summary>
        /// Affichage de la forme de Gestion des Vétérinaires + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficherVétérinaires(object sender, EventArgs e)
        {
            FormVétérinaires frm;
            if (!vétérinairesToolStripMenuItem.Checked)
            {
                frm = new FormVétérinaires();
                frm.MdiParent = this;
                frm.Show();
                vétérinairesToolStripMenuItem.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
        }

        #endregion

        #region Clients

        /// <summary>
        /// Affichage de la forme de Gestion des Clients + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficherClients(object sender, EventArgs e)
        {
            FormClients frm;
            if (!dossierClientAnimauxToolStripMenuItem.Checked)
            {
                frm = new FormClients();
                frm.MdiParent = this;
                frm.Show();
                dossierClientAnimauxToolStripMenuItem.Checked = true;
                toolStripBt_Client.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
            else
            {
                frm = (FormClients)Array.Find(this.MdiChildren, (Form f) => f.Name == "FormClients");
                frm.BringToFront();
            }
        }

        #endregion Clients

        #region Agenda et RDV

        /// <summary>
        /// Affichage de la forme de Gestion de l'Agenda + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficherAgenda(object sender, EventArgs e)
        {
            FormAgenda frm;
            if (!agendaToolStripMenuItem.Checked)
            {
                frm = new FormAgenda();
                frm.MdiParent = this;
                frm.Show();
                agendaToolStripMenuItem.Checked = true;
                toolStripBt_Agenda.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
            else
            {
                frm = (FormAgenda)Array.Find(this.MdiChildren, (Form f) => f.Name == "FormAgenda");
                frm.BringToFront();
            }
        }

        /// <summary>
        /// Affichage de la forme de Gestion des Prises de RDV + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficherRDV(object sender, EventArgs e)
        {
            FormRDV frm;
            if (!priseDeRendezVousToolStripMenuItem.Checked)
            {
                frm = new FormRDV();
                frm.MdiParent = this;
                frm.Show();
                priseDeRendezVousToolStripMenuItem.Checked = true;
                toolStripBt_RDV.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
            else
            {
                frm = (FormRDV)Array.Find(this.MdiChildren, (Form f) => f.Name == "FormRDV");
                frm.BringToFront();
            }
        }

        #endregion

        #region Dossier Médicaux

        /// <summary>
        /// Affichage de la forme de Gestion des Dossiers Médicaux + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficherDossier(object sender, EventArgs e)
        {
            FormSelection_Animal frm;
            if (!dossiersMédicauxToolStripMenuItem.Checked)
            {
                frm = new FormSelection_Animal();
                frm.MdiParent = this;
                frm.Show();
                dossiersMédicauxToolStripMenuItem.Checked = true;
                toolStripBt_Dossier.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
            else
            {
                frm = (FormSelection_Animal)Array.Find(this.MdiChildren, (Form f) => f.Name == "FormSelection_Animal");
                frm.BringToFront();
            }
        }

        #endregion

        #region Factures

        /// <summary>
        /// Affichage de la forme de Gestion des Relances des Factures + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficherRelanceFacture(object sender, EventArgs e)
        {
            FormRelance_FactureSelection frm;
            if (!relancesFacturesToolStripMenuItem.Checked)
            {
                frm = new FormRelance_FactureSelection();
                frm.MdiParent = this;
                frm.Show();
                relancesFacturesToolStripMenuItem.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
        }

        /// <summary>
        /// Affichage de la forme de Création des Factures + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficherCreationFacture(object sender, EventArgs e)
        {
            FormFactures frm;
            if (!créationDeFacturesToolStripMenuItem.Checked)
            {
                frm = new FormFactures();
                frm.MdiParent = this;
                frm.Show();
                créationDeFacturesToolStripMenuItem.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
        }

        /// <summary>
        /// Affichage de la forme d'Impression des Factures + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficherImpressionFacture(object sender, EventArgs e)
        {
            FormSelection_Facture frm;
            if (!impressionDeFacturesToolStripMenuItem.Checked)
            {
                frm = new FormSelection_Facture();
                frm.MdiParent = this;
                frm.Show();
                impressionDeFacturesToolStripMenuItem.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
        }

        /// <summary>
        /// Affichage de la forme de Réglement des Factures + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficheRèglementFacture(object sender, EventArgs e)
        {
            FormFactures_Règlement frm;
            if (!réglementDuneFactureToolStripMenuItem.Checked)
            {
                frm = new FormFactures_Règlement();
                frm.MdiParent = this;
                frm.Show();
                réglementDuneFactureToolStripMenuItem.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
        }

        #endregion

        #region Vaccins

        /// <summary>
        /// Affichage de la forme de Gestion des Stocks + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficherStocks(object sender, EventArgs e)
        {
            FormStock frm;
            if (!miseÀJourDuStockDeVaccinsToolStripMenuItem.Checked)
            {
                frm = new FormStock();
                frm.MdiParent = this;
                frm.Show();
                miseÀJourDuStockDeVaccinsToolStripMenuItem.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
        }

        /// <summary>
        /// Affichage de la forme de Gestion des Barèmes + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficherBarèmes(object sender, EventArgs e)
        {
            FormBarèmes frm;
            if (!miseÀJourDuBarèmeToolStripMenuItem.Checked)
            {
                frm = new FormBarèmes();
                frm.MdiParent = this;
                frm.Show();
                miseÀJourDuBarèmeToolStripMenuItem.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
        }

        /// <summary>
        /// Affichage de la forme de Gestion des Relances des Vaccins + écoute de la fermeture de cette fenêtre
        /// </summary>
        private void AfficherRelanceVaccin(object sender, EventArgs e)
        {
            FormRelance_VaccinSelection frm;
            if (!relancesVaccinationToolStripMenuItem.Checked)
            {
                frm = new FormRelance_VaccinSelection();
                frm.MdiParent = this;
                frm.Show();
                relancesVaccinationToolStripMenuItem.Checked = true;
                toolStripBt_Relance.Checked = true;
                frm.BringToFront();
                frm.FormClosed += FermetureFille;
            }
            else
            {
                frm = (FormRelance_VaccinSelection)Array.Find(this.MdiChildren, (Form f) => f.Name == "FormRelance_VaccinSelection");
                frm.BringToFront();
            }
        }

        #endregion

        #region Fermeture des Fenêtres

        /// <summary>
        /// Identifie la fenêtre qui vient d'être fermée pour décocher l'(les) option(s) correspondante(s) dans les menus
        /// </summary>
        private void FermetureFille(object sender, FormClosedEventArgs e)
        {
            // Identifie l'occurence de la fenêtre fermée
            Form f = (Form)sender;
            if (f is FormRDV)
            {
                priseDeRendezVousToolStripMenuItem.Checked = false;
                toolStripBt_RDV.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else if (f is FormClients)
            {
                dossierClientAnimauxToolStripMenuItem.Checked = false;
                toolStripBt_Client.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else if (f is FormRelance_VaccinSelection)
            {
                relancesVaccinationToolStripMenuItem.Checked = false;
                toolStripBt_Relance.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else if (f is FormAgenda)
            {
                agendaToolStripMenuItem.Checked = false;
                toolStripBt_Agenda.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else if (f is FormSelection_Animal || f is FormDossierMédical)
            {
                dossiersMédicauxToolStripMenuItem.Checked = false;
                toolStripBt_Dossier.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else if (f is FormFactures_Règlement)
            {
                réglementDuneFactureToolStripMenuItem.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else if (f is FormSelection_Facture)
            {
                impressionDeFacturesToolStripMenuItem.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else if (f is FormFactures)
            {
                créationDeFacturesToolStripMenuItem.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else if (f is FormRelance_FactureSelection)
            {
                relancesFacturesToolStripMenuItem.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else if (f is FormBarèmes)
            {
                miseÀJourDuBarèmeToolStripMenuItem.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else if (f is FormVétérinaires)
            {
                vétérinairesToolStripMenuItem.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else if (f is FormStock)
            {
                miseÀJourDuStockDeVaccinsToolStripMenuItem.Checked = false;
                f.FormClosed -= FermetureFille;
            }
            else
            {
                f.FormClosed -= FermetureFille;
            }
        }

        #endregion
    }
}
