using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Facture
    {
        #region Attributs et Accesseurs

        public Guid numFacture { get; set; }
        public DateTime dateFacture { get; set; }
        public Guid codeClient { get; set; }
        public String nomVeto { get; set; }
        public String nomAnimal { get; set; }
        public String nomClient { get; set; }
        public DateTime dateConsult { get; set; }
        public Decimal totalFacture { get; set; }
        public bool archive { get; set; }
        public int etat { get; set; }
        public DateTime? rappelEnvoye { get; set; }

        #endregion

        #region Constructeurs

        public Facture()
        {
        }

        public Facture(Guid NumFacture, DateTime DateFacture, int Etat, DateTime? RappelEnvoye = null, bool Archive = false)
        {
            this.numFacture = NumFacture;
            this.dateFacture = DateFacture;
            this.archive = Archive;
            this.etat = Etat;
            this.rappelEnvoye = RappelEnvoye;
        }

        #endregion
    }
}
