using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtBareme
    {
        #region Méthodes CRUD

        // Create

        public static bool AddBareme(Bareme pBareme)
        {
            return DALBarème.AddBareme(pBareme);
        }

        // Read

        public static List<Bareme> GetBaremes()
        {
            return DALBarème.GetBaremes();
        }

        public static Bareme GetBareme(String libelle)
        {
            return DALBarème.GetBareme(libelle);
        }

        public static List<String> GetTypesActes()
        {
            return DALBarème.GetTypesActes();
        }

        public static List<String> GetDateVigueurActe(String libelle)
        {
            return DALBarème.GetDateVigueurActe(libelle);
        }

        public static List<String> GetLibelleActe(String type)
        {
            return DALBarème.GetLibelleActe(type);
        }

        public static List<Decimal> GetTarifsActes(String libelle)
        {
            return DALBarème.GetTarifsActes(libelle);
        }

        public static int GetDernierCodeVaccin()
        {
            return DALBarème.GetDernierCodeVaccin();
        }

        // Update

        public static bool SetBaremeArchive(Bareme pBareme)
        {
            return DALBarème.SetBaremeArchive(pBareme);
        }

        #endregion
    }
}
