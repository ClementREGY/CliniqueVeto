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
    public partial class FormAnimaux : Form
    {
        private FormClients frmClients;

        public FormAnimaux(FormClients frm)
        {
            InitializeComponent();
            frmClients = frm;
        }

        private void FormAnimaux_Load(object sender, EventArgs e)
        {
            if (frmClients.ModeAnimal == "Ajout")
            {
                CBox_Genre.SelectedIndex = 0;
                CBox_Espèce.SelectedIndex = 0;
            }
        }
    }
}
