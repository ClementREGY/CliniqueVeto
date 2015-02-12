using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class MgtVaccin
    {
        // Read
        public static List<Vaccin> GetVaccins()
        {
            return DALVaccin.GetVaccins();
        }

        // Create
        public static Guid CreateVaccin(Vaccin pVaccin)
        {
            return DALVaccin.AddVaccin(pVaccin);
        }

        // Update
        public static bool UpdateVaccin(Vaccin pVaccin)
        {
            return DALVaccin.SetVaccin(pVaccin);
        }
    }
}
