using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Animal
    {
        [Browsable(false)]
        public Guid codeAnimal { get; set; }

        [DisplayName("Nom")]
        public string nomAnimal { get; set; }

        [DisplayName("Sexe")]
        public string sexe { get; set; }

        [DisplayName("Couleur")]
        public string couleur { get; set; }

        [DisplayName("Race")]
        public string race { get; set; }

        [DisplayName("Espèce")]
        public string espece { get; set; }

        [Browsable(false)]
        public string client { get; set; }

        [DisplayName("Tatouage")]
        public string tatouage { get; set; }

        [Browsable(false)]
        public string antecedents { get; set; }

        [Browsable(false)]
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

        public override string ToString()
        {
            return this.espece + " " + this.nomAnimal;
        }
    }
}
