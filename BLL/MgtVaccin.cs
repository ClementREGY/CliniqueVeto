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
        //Read
        public static List<Vaccin> GetVaccins()
        {
            return DALVaccin.GetVaccins();
        }

        //Update
        public static bool UpdateVaccin(Vaccin pVaccin)
        {
            return DALVaccin.SetVaccin(pVaccin);
        }
    }
}
