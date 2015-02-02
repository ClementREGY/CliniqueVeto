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
        public string nomClient { get; set; }
        public string prenomClient { get; set; }
        public string adresse { get; set; }
        public string adresse2 { get; set; }
        public string cp { get; set; }
        public string ville { get; set; }
        public string numTel { get; set; }
        public string assurance { get; set; }
        public string email { get; set; }
        public string remarque { get; set; }
        public bool archive { get; set; }

        public Client()
        {
        }

        public Client(Guid CodeClient, string NomClient, string PrenomClient, string Adresse, string Adresse2,
            string CP, string Ville, string NumTel, string Assurance, string Email, string Remarque, bool Archive)
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
