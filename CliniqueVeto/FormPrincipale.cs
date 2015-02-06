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
        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void AfficherStocks(object sender, EventArgs e)
        {
            FormStock frm;
            frm = new FormStock();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
            // Se mettre à l'écoute de l'évènement FormClosing de la feuille fille.
            frm.FormClosed += FermetureFille;
        }

        private void AfficherVétérinaires(object sender, EventArgs e)
        {
            FormVétérinaires frm;
            frm = new FormVétérinaires();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
            // Se mettre à l'écoute de l'évènement FormClosing de la feuille fille.
            frm.FormClosed += FermetureFille;
        }

        private void AfficherBarèmes(object sender, EventArgs e)
        {
            FormBarèmes frm;
            frm = new FormBarèmes();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
            // Se mettre à l'écoute de l'évènement FormClosing de la feuille fille.
            frm.FormClosed += FermetureFille;
        }

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
                // Se mettre à l'écoute de l'évènement FormClosing de la feuille fille.
                frm.FormClosed += FermetureFille;
            }
            else
            {
                frm = (FormRDV)Array.Find(this.MdiChildren, (Form f) => f.Name == "FormRDV");
                frm.BringToFront();
            }
        }

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
                // Se mettre à l'écoute de l'évènement FormClosing de la feuille fille.
                frm.FormClosed += FermetureFille;
            }
            else
            {
                frm = (FormClients)Array.Find(this.MdiChildren, (Form f) => f.Name == "FormClients");
                frm.BringToFront();
            }
        }

        private void AfficherRelance(object sender, EventArgs e)
        {
            FormRelance frm;
            if (!relancesToolStripMenuItem.Checked)
            {
                frm = new FormRelance();
                frm.MdiParent = this;
                frm.Show();
                relancesToolStripMenuItem.Checked = true;
                toolStripBt_Relance.Checked = true;
                frm.BringToFront();
                // Se mettre à l'écoute de l'évènement FormClosing de la feuille fille.
                frm.FormClosed += FermetureFille;
            }
            else
            {
                frm = (FormRelance)Array.Find(this.MdiChildren, (Form f) => f.Name == "FormRelance");
                frm.BringToFront();
            }
        }

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
                // Se mettre à l'écoute de l'évènement FormClosing de la feuille fille.
                frm.FormClosed += FermetureFille;
            }
            else
            {
                frm = (FormAgenda)Array.Find(this.MdiChildren, (Form f) => f.Name == "FormAgenda");
                frm.BringToFront();
            }
        }

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
                // Se mettre à l'écoute de l'évènement FormClosing de la feuille fille.
                frm.FormClosed += FermetureFille;
            }
            else
            {
                frm = (FormSelection_Animal)Array.Find(this.MdiChildren, (Form f) => f.Name == "FormSelection_Animal");
                frm.BringToFront();
            }
        }

        private void FermetureFille(object sender, FormClosedEventArgs e)
        {
            //Identifie l'occurence de fenêtre fermée pour décocher la bonne option de menu.
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
            else if (f is FormRelance)
            {
                relancesToolStripMenuItem.Checked = false;
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
            else
            {
                f.FormClosed -= FermetureFille;
            }
        }
    }
}
