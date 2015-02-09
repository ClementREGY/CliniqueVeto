using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BO;

namespace BLL
{
    public class MgtRelance
    {
        #region Méthodes CRUD
        //Read
        public static List<Relance> GetRelances()
        {
            return DALRelance.GetRelances();
        }
        //Update
        public static bool SetRelanceEnvoye(Relance pRelance)
        {
            return DALRelance.SetRelanceEnvoye(pRelance);
        }
        #endregion
    }
}
