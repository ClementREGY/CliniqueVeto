using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtRace
    {
        #region Méthodes CRUD

        // Create

        public static bool CreateRace(Race uneRace)
        {
            return DALRace.AddRace(uneRace);
        }

        // Read

        public static List<String> GetEspeces()
        {
            return DALRace.GetEspeces();
        }

        public static List<String> GetRaces(String espece)
        {
            return DALRace.GetRaces(espece);
        }

        #endregion
    }
}
