using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtLogin
    {
        // Create
        public static bool CreateLogin(Login pLogin)
        {
            return DALLogin.AddLogin(pLogin);
        }

        // Read
        public static List<Login> GetLogins()
        {
            return DALLogin.GetLogins();
        }

        // Update
        public static bool UpdateLogin(Login pLogin)
        {
            return DALLogin.SetLogin(pLogin);
        }

        // Delete
        public static bool DeleteLogin(Login pLogin)
        {
            return DALLogin.DeleteLogin(pLogin);
        }
    }
}
