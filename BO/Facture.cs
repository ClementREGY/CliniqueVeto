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
        public float totalFacture { get; set; }
        public bool archive { get; set; }
        public string etat { get; set; }
        public string rappelEnvoye { get; set; }

        #endregion

        #region Constructeurs

        public Facture()
        {
        }

        public Facture(Guid NumFacture, DateTime DateFacture, Guid CodeClient, float TotalFacture, bool Archive,
            string Etat, string RappelEnvoye)
        {
            this.numFacture = NumFacture;
            this.dateFacture = DateFacture;
            this.codeClient = CodeClient;
            this.totalFacture = TotalFacture;
            this.archive = Archive;
            this.etat = Etat;
            this.rappelEnvoye = RappelEnvoye;
        }

        #endregion
    }
}
