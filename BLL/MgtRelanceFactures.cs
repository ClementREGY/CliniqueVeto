using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class MgtRelanceFactures
    {
        #region Méthodes CRUD
        //Read
        public static List<Facture> GetRelances()
        {
            return DALRelanceFactures.GetRelances();
        }
        //Update
        public static bool SetRelanceEnvoye(Facture pRelance)
        {
            return DALRelanceFactures.SetRelanceEnvoye(pRelance);
        }
        #endregion
    }
}
