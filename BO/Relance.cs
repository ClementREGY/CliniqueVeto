using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Relance
    {
        #region Attributs et Accesseurs

        [Browsable(false)]
        public Guid codeConsultation { get; set; }

        [Browsable(false)]
        public Guid numLigne { get; set; }

        [DisplayName("Date Vigueur")]
        public DateTime dateVigueur { get; set; }

        [DisplayName("Vaccin")]
        public string nomVaccin { get; set; }

        [DisplayName("Validité (mois)")]
        public int periodeValidite { get; set; }

        [DisplayName("Animal")]
        public string nomAnimal { get; set; }

        [Browsable(false)]
        public string nomClient { get; set; }

        [Browsable(false)]
        public string prenomClient { get; set; }
        
        [DisplayName("Client")]
        public String nomPrenom
        {
            get { return nomClient + " " + prenomClient; }
        }

        #endregion

        #region Constructeurs

        public Relance(Guid CodeConsultation, Guid NumLigne, DateTime DateVigueur, String NomVaccin, int PeriodeValidite,
            String NomAnimal, String NomClient, String PrenomClient)
        {
            this.codeConsultation = CodeConsultation;
            this.numLigne = NumLigne;
            this.dateVigueur = DateVigueur;
            this.nomVaccin = NomVaccin;
            this.periodeValidite = PeriodeValidite;
            this.nomAnimal = NomAnimal;
            this.nomClient = NomClient;
            this.prenomClient = PrenomClient;
        }

        public Relance()
        {
        }
        #endregion
    }
}
