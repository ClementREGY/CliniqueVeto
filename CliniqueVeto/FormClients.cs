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
    public partial class FormClients : Form
    {
        #region Attributs et Propriétés

        private String _modeAnimal;

        public String ModeAnimal 
        { 
            get { return _modeAnimal; } 
            set { _modeAnimal = value; } 
        }

        #endregion

        public FormClients()
        {
            InitializeComponent();
        }

        private void FormClients_Load(object sender, EventArgs e)
        {

        }

        private void BTN_AjouterAnimal_Click(object sender, EventArgs e)
        {
            _modeAnimal = "Ajout";
            FormAnimaux frm = new FormAnimaux(this);
            frm.Show();
            frm.BringToFront();            
        }

        private void BTN_EditerAnimal_Click(object sender, EventArgs e)
        {
            _modeAnimal = "Modification";
            FormAnimaux frm = new FormAnimaux(this);
            frm.Show();
            frm.BringToFront();
        }
    }
}
