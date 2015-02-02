using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Animal
    {
        public Guid codeAnimal { get; set; }
        public string nomAnimal { get; set; }
        public string sexe { get; set; }
        public string couleur { get; set; }
        public string race { get; set; }
        public string espece { get; set; }
        public Client codeClient { get; set; }
        public bool tatouage { get; set; }
        public string antecedents { get; set; }
        public bool archive { get; set; }

        public Animal()
        {
        }

        public Animal(Guid CodeAnimal, string NomAnimal, string Sexe, string Couleur, string Race, string Espece,
            Client CodeClient, bool Tatouage, string Antecedents, bool Archive)
        {
            this.codeAnimal = CodeAnimal;
            this.nomAnimal = NomAnimal;
            this.sexe = Sexe;
            this.couleur = Couleur;
            this.race = Race;
            this.espece = Espece;
            this.codeClient = CodeClient;
            this.tatouage = Tatouage;
            this.antecedents = Antecedents;
            this.archive = Archive;
        }
    }
}
