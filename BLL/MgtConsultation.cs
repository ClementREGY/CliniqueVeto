using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtConsultation
    {
        #region Méthodes CRUD

        // Create

        public static Guid CreateConsultation(Consultation laConsultation)
        {
            return DALConsultation.AddConsultation(laConsultation);
        }

        // Read
        public static List<Consultation> GetConsultations()
        {
            return DALConsultation.GetConsultations();
        }

        public static List<Consultation> GetConsultationsByAnimal(Guid IdAnimal)
        {
            return DALConsultation.GetConsultationsByAnimal(IdAnimal);
        }

        public static Consultation GetConsultation(Guid IdConsult)
        {
            return DALConsultation.GetConsultation(IdConsult);
        }      

        #endregion
    }
}
