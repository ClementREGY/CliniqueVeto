using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Consultation
    {
        #region Attributs et Accesseurs

        public Guid codeConsultation { get; set; }
        public DateTime dateConsultation { get; set; }
        public Guid codeVeto { get; set; }
        public Guid codeAnimal { get; set; }
        public String commentaire { get; set; }
        public int etat { get; set; }
        public String numFacture { get; set; }
        public bool archive { get; set; }
        public List<Acte> actes { get; set; }

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
        }

        #endregion
    }
}
