using System;
using BLL;
using BO;
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
    public partial class FormVétérinaires : Form
    {
        #region Attributs et Propriétés

        public Veterinaire _veterinaireCourant 
        {
            get { return (Veterinaire)LBox_Vetos.SelectedItem; }
        }

        #endregion

        public FormVétérinaires()
        {
            InitializeComponent();
        }

        private void FormVétérinaires_Load(object sender, EventArgs e)
        {
            LBox_Vetos.DataSource = MgtVeterinaire.GetVeterinaires();
            LBox_Vetos.DisplayMember = "NomVeto";
        }

        #region Gestion des Boutons

        /// <summary>
        /// Ouverture de la fenêtre de formulaire d'ajout d'un nouveau Vétérinaire
        /// </summary>
        private void toolStripBt_Ajouter_Click(object sender, EventArgs e)
        {
            FormAjout_Vétérinaire frmAjout = new FormAjout_Vétérinaire();
            frmAjout.ShowDialog();
            LBox_Vetos.DataSource = MgtVeterinaire.GetVeterinaires();
        }

        /// <summary>
        /// Suppression du vétérinaire sélectionné après confirmation
        /// </summary>
        private void toolStripBt_Suppr_Click(object sender, EventArgs e)
        {           
            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce Vétérinaire ?", "Attention", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                MgtVeterinaire.DeleteVeterinaire((Veterinaire)LBox_Vetos.SelectedItem);
            }
            LBox_Vetos.DataSource = MgtVeterinaire.GetVeterinaires();
        }

        /// <summary>
        /// Ouverture de la fenêtre de formulaire de modification de mot de passe du Vétérinaire sélectionné
        /// </summary>
        private void toolStripBt_Reinit_Click(object sender, EventArgs e)
        {
            FormReinit_Vétérinaire frmReinit = new FormReinit_Vétérinaire(this);
            frmReinit.ShowDialog();
            LBox_Vetos.DataSource = MgtVeterinaire.GetVeterinaires();
        }

        #endregion
    }
}
