using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Consultation
    {
        #region Attributs et Accesseurs

        private List<Acte> _actes;

        [Browsable(false)]
        public Guid codeConsultation { get; set; }
        [DisplayName("Date")]
        public DateTime dateConsultation { get; set; }

        [Browsable(false)]
        public Guid codeVeto { get; set; }
        [DisplayName("Vétérinaire")]
        public String nomVeto { get; set; }

        [Browsable(false)]
        public Guid codeAnimal { get; set; }
        [DisplayName("Animal")]
        public String nomAnimal { get; set; }
        [DisplayName("Client")]
        public String nomClient { get; set; }

        [Browsable(false)]
        public String commentaire { get; set; }
        [Browsable(false)]
        public int etat { get; set; }
        [Browsable(false)]
        public String numFacture { get; set; }
        [Browsable(false)]
        public bool archive { get; set; }
        [Browsable(false)]
        public List<Acte> actes { get { return _actes; } set { _actes = value; } }

        #endregion

        #region Constructeurs

        public Consultation()
        {
        }

        public Consultation(Guid CodeConsultation, DateTime DateConsultation, Guid CodeVeto, Guid CodeAnimal, int Etat, String NumFacture = null, String Commentaire = null, bool Archive = false)
        {
            this.codeConsultation = CodeConsultation;
            this.dateConsultation = DateConsultation;
            this.codeVeto = CodeVeto;
            this.codeAnimal = CodeAnimal;
            this.commentaire = Commentaire;
            this.etat = Etat;
            this.numFacture = NumFacture;
            this.archive = Archive;
            _actes = new List<Acte>();
        }

        #endregion
    }
}
