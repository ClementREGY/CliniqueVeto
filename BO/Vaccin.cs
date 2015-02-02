using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Vaccin
    {
        public Guid codeVaccin { get; set; }
        public string nomVaccin { get; set; }
        public int quantiteStock { get; set; }
        public int periodeValidite { get; set; }
        public bool archive { get; set; }

        public Vaccin()
        {
        }

        public Vaccin(Guid CodeVaccin, string NomVaccin, int QuantiteStock, int PeriodeValidite, bool Archive)
        {
            this.codeVaccin = CodeVaccin;
            this.nomVaccin = NomVaccin;
            this.quantiteStock = QuantiteStock;
            this.periodeValidite = PeriodeValidite;
            this.archive = Archive;
        }
    }
}
