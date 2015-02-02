using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Veterinaire
    {
        public Guid codeVeto { get; set; }
        public string nomVeto { get; set; }
        public bool archive { get; set; }

        public Veterinaire()
        {
        }

        public Veterinaire(Guid CodeVeto, string NomVeto, bool Archive)
        {
            this.codeVeto = CodeVeto;
            this.nomVeto = NomVeto;
            this.archive = Archive;
        }
    }
}
