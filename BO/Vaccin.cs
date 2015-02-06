using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Vaccin
    {
        [Browsable(false)]
        public Guid codeVaccin { get; set; }
        [DisplayName("Nom du vaccin")]
        public string nomVaccin { get; set; }
        [DisplayName("Quantité en Stock")]
        public int quantiteStock { get; set; }
        [DisplayName("Période de Validité")]
        public int periodeValidite { get; set; }
        [Browsable(false)]
        public bool archive { get; set; }

        public Vaccin()
        {
        }

        public Vaccin(Guid CodeVaccin, string NomVaccin, int QuantiteStock, int PeriodeValidite, bool Archive = false)
        {
            this.codeVaccin = CodeVaccin;
            this.nomVaccin = NomVaccin;
            this.quantiteStock = QuantiteStock;
            this.periodeValidite = PeriodeValidite;
            this.archive = Archive;
        }
    }
}
