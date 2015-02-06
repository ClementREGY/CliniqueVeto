using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Relance
    {
        public string dateVigueur { get; set; }
        public string nomVaccin { get; set; }
        public int periodeValidite { get; set; }

        public Relance(String DateVigueur, String NomVaccin, int PeriodeValidite)
        {
            this.dateVigueur = DateVigueur;
            this.nomVaccin = NomVaccin;
            this.periodeValidite = PeriodeValidite;
        }

        public Relance()
        {
        }
    }
}
