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
        public string client { get; set; }
        public string tatouage { get; set; }
        public string antecedents { get; set; }
        public bool archive { get; set; }

        public Animal()
        {
        }

        public Animal(Guid CodeAnimal, String NomAnimal, String Sexe, String Race, String Espece,
            String Client, bool Archive = false, String Couleur = null, String Tatouage = null, String Antecedents = null)
        {
            this.codeAnimal = CodeAnimal;
            this.nomAnimal = NomAnimal;
            this.sexe = Sexe;
            this.couleur = Couleur;
            this.race = Race;
            this.espece = Espece;
            this.client = Client;
            this.tatouage = Tatouage;
            this.antecedents = Antecedents;
            this.archive = Archive;
        }
    }
}
