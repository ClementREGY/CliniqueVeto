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
        [Browsable(false)]
        public Guid codeConsultation { get; set; }
        [Browsable(false)]
        public Guid numLigne { get; set; }
        [DisplayName("Date en vigueur")]
        public DateTime dateVigueur { get; set; }
        [DisplayName("Nom du vaccin")]
        public string nomVaccin { get; set; }
        [DisplayName("Période de validité")]
        public int periodeValidite { get; set; }
        [DisplayName("Nom Animal")]
        public string nomAnimal { get; set; }
        [DisplayName("Nom Client")]
        public string nomClient { get; set; }
        [DisplayName("Prénom Client")]
        public string prenomClient { get; set; }

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
    }
}
