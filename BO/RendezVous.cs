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
        #region Attributs et Accesseurs

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

        [DisplayName("Vétérinaire")]
        public String nomVeto { get; set; }

        [DisplayName("Heure")]
        public DateTime dateRDV { get; set; }

        [DisplayName("Urgence")]
        public bool urgence { get; set; }

        #endregion

        #region Constructeurs

        public RendezVous()
        {
        }

        public RendezVous(DateTime DateRDV, String NomClient, String PrenomClient, String NomAnimal, String NomVeto, bool Urgence = false)
        {
            this.nomClient = NomClient;
            this.prenomClient = PrenomClient;
            this.nomAnimal = NomAnimal;
            this.nomVeto = NomVeto;
            this.dateRDV = DateRDV;
            this.urgence = Urgence;
        }

        #endregion
    }
}
