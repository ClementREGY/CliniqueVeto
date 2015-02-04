using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Client
    {
        public Guid codeClient { get; set; }
        public String nomClient { get; set; }
        public String prenomClient { get; set; }
        public String nomPrenom
        {
            get { return nomClient + " " + prenomClient; }
        }
        public String adresse { get; set; }
        public String adresse2 { get; set; }
        public String cp { get; set; }
        public String ville { get; set; }
        public String numTel { get; set; }
        public String assurance { get; set; }
        public String email { get; set; }
        public String remarque { get; set; }
        public bool archive { get; set; }

        public Client()
        {
        }

        public Client(Guid CodeClient, String NomClient, String PrenomClient, String Adresse,
            String CP, String Ville, String NumTel = null, String Assurance = null, String Email = null, String Remarque = null, bool Archive = false, String Adresse2 = null)
        {
            this.codeClient = CodeClient;
            this.nomClient = NomClient;
            this.prenomClient = PrenomClient;
            this.adresse = Adresse;
            this.adresse2 = Adresse2;
            this.cp = CP;
            this.ville = Ville;
            this.numTel = NumTel;
            this.assurance = Assurance;
            this.email = Email;
            this.remarque = Remarque;
            this.archive = Archive;
        }
    }
}
