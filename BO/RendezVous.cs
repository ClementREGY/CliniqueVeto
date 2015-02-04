using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class RendezVous
    {
        #region Attributs

        [Browsable(false)]
        public String nomClient { get; set; }

        [Browsable(false)]
        public String prenomClient { get; set; }

        [Browsable(true)]
        [DisplayName("Client")]
        public String NomPrenom 
        { 
            get { return nomClient + " " + prenomClient;} 
        }

        [DisplayName("Animal")]
        public String nomAnimal { get; set; }

        [Browsable(false)]
        public String nomVeto { get; set; }

        [DisplayName("Heure")]
        public DateTime dateRDV { get; set; }

        #endregion

        #region Constructeurs

        public RendezVous()
        {
        }

        public RendezVous(DateTime DateRDV, String NomClient, String PrenomClient, String NomAnimal, String NomVeto)
        {
            this.nomClient = NomClient;
            this.prenomClient = PrenomClient;
            this.nomAnimal = NomAnimal;
            this.nomVeto = NomVeto;
            this.dateRDV = DateRDV;
        }

        #endregion
    }
}
