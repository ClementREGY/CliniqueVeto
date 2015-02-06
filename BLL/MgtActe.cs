using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtActe
    {
        #region Méthodes CRUD

        // Read
        public static List<Acte> GetActesByConsultation(Guid IdConsult)
        {
            return DALActe.GetActesByConsultation(IdConsult);
        }

        public static Acte GetActe(Guid IdActe)
        {
            return DALActe.GetActe(IdActe);
        }

        #endregion
    }
}
