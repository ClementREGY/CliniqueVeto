using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtFacture
    {
        #region Méthodes CRUD

        // Create

        public static Guid CreateFacture(Facture laFacture)
        {
            return DALFacture.AddFacture(laFacture);
        }

        // Read

        public static List<Facture> GetFactures()
        {
            return DALFacture.GetFactures();
        }

        public static List<Facture> GetFacturesImpayees()
        {
            return DALFacture.GetFacturesImpayees();
        }

        public static Facture GetFacture(Guid NumFacture)
        {
            return DALFacture.GetFacture(NumFacture);
        }

        // Update

        public static bool UpdateFactureImprimee(Guid NumFacture)
        {
            return DALFacture.SetFactureImprimee(NumFacture);
        }

        public static bool UpdateFacturePayee(Guid NumFacture)
        {
            return DALFacture.SetFacturePayee(NumFacture);
        }

        #endregion
    }
}
