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
    public partial class FormAjout_EspècesRaces : Form
    {
        #region Attributs et Propriétés

        private String _espece, _race;

        public String Espece
        {
            get { return _espece; }
            set { _espece = value; }
        }

        public String Race
        {
            get { return _race; }
            set { _race = value; }
        }

        #endregion

        public FormAjout_EspècesRaces(String uneEspece = null)
        {
            InitializeComponent();
            if (uneEspece != null)
                Espece = uneEspece;
        }

        private void FormAjout_EspècesRaces_Load(object sender, EventArgs e)
        {
            if (Espece != null)
            {
                TBox_Espèce.Text = Espece;
                TBox_Espèce.Enabled = false;
            }
        }

        #region Validation

        /// <summary>
        /// Vérifie que tous les Champs ont été saisis, puis ajoute la Race
        /// </summary>
        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBox_Espèce.Text.Trim()))
            {
                errorSaisie.SetError(TBox_Espèce, "Veuillez saisir une Espèce.");
            }
            else
            {
                if (String.IsNullOrEmpty(TBox_Race.Text.Trim()))
                {
                    errorSaisie.SetError(TBox_Race, "Veuillez saisir une Race.");
                }
                else
                {
                    Espece = TBox_Espèce.Text;
                    Race = TBox_Race.Text;

                    Race newRace = new Race(Race, Espece);
                    MgtRace.CreateRace(newRace);

                    this.Close();
                }
            }
        }

        #endregion
    }
}
