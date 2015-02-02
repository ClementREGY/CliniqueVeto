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

        private void miseÀJourDuBarèmeToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                frm = (FormRDV)Array.Find(this.MdiChildren, (Form f) => f.Name == "FrmEmployes");
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
                frm = (FormClients)Array.Find(this.MdiChildren, (Form f) => f.Name == "FrmEmployes");
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
            else
            {
                f.FormClosed -= FermetureFille;
            }
        }


    }
}
