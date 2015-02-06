using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BO
{
    public class Veterinaire
    {
        #region Attributs et Accesseurs

        public Guid codeVeto { get; set; }
        public string nomVeto { get; set; }
        public bool archive { get; set; }
        public int refLogin { get; set; }

        #endregion

        #region Constructeurs

        public Veterinaire()
        {
        }

        public Veterinaire(Guid CodeVeto, string NomVeto, int RefLogin, bool Archive = false)
        {
            this.codeVeto = CodeVeto;
            this.nomVeto = NomVeto;
            this.archive = Archive;
            this.refLogin = RefLogin;
        }

        #endregion
    }
}
