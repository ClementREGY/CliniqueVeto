using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtVeterinaire
    {
        #region Méthodes CRUD

        // Create 
        public static bool CreateVeterinaire(Veterinaire veterinaire)
        {
            return DALVétérinaire.AddVeterinaire(veterinaire);
        }

        // Read
        public static List<Veterinaire> GetVeterinaires()
        {
            return DALVétérinaire.GetVeterinaires();
        }

        public static Veterinaire GetVeterinaire(Guid IdVeto)
        {
            return DALVétérinaire.GetVeterinaire(IdVeto);
        }

        // Update
        public static bool UpdateVeterinaire(Veterinaire veterinaire)
        {
            return DALVétérinaire.SetVeterinaire(veterinaire);
        }

        // Delete
        public static bool DeleteVeterinaire(Veterinaire veterinaire)
        {
            return DALVétérinaire.DeleteVeterinaire(veterinaire);
        }

        #endregion
    }
}
