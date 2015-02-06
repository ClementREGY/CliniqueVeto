using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Race
    {
        #region Attributs et Accesseurs

        public string race { get; set; }
        public string espece { get; set; }

        #endregion

        #region Constructeurs

        public Race()
        {
        }

        public Race(string Race, string Espece)
        {
            this.race = Race;
            this.espece = Espece;
        }

        #endregion
    }
}
