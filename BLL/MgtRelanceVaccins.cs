using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BO;

namespace BLL
{
    public class MgtRelanceVaccins
    {
        #region Méthodes CRUD
        //Read
        public static List<RelanceVaccins> GetRelances()
        {
            return DALRelanceVaccins.GetRelances();
        }
        //Update
        public static bool SetRelanceEnvoye(RelanceVaccins pRelance)
        {
            return DALRelanceVaccins.SetRelanceEnvoye(pRelance);
        }
        #endregion
    }
}
