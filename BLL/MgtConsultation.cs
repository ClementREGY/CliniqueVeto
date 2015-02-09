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

        public static List<String> GetTypesActes()
        {
            return DALConsultation.GetTypesActes();
        }

        public static List<String> GetLibellesActes(String type)
        {
            return DALConsultation.GetLibellesActes(type);
        }

        public static List<Decimal> GetTarifsActes(String libelle)
        {
            return DALConsultation.GetTarifsActes(libelle);
        }

        #endregion
    }
}
