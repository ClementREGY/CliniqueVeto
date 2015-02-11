using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Facture
    {
        #region Attributs et Accesseurs

        [Browsable(false)]
        public Guid numFacture { get; set; }

        [DisplayName("Date Facturation")]
        public DateTime dateFacture { get; set; }

        [Browsable(false)]
        public Guid codeClient { get; set; }

        [Browsable(false)]
        public String nomVeto { get; set; }

        [Browsable(false)]
        public String adresseClient { get; set; }

        [DisplayName("Animal")]
        public String nomAnimal { get; set; }

        [DisplayName("Client")]
        public String nomClient { get; set; }

        [DisplayName("Date Consultation")]
        public DateTime dateConsult { get; set; }

        [Browsable(false)]
        public Guid codeConsult { get; set; }

        [DisplayName("Montant")]
        public Decimal totalFacture { get; set; }

        [Browsable(false)]
        public bool archive { get; set; }

        [Browsable(false)]
        public int etat { get; set; }

        [Browsable(false)]
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
