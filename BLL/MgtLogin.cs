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
        #region Méthodes CRUD

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

        #endregion

        #region Authentification

        public static bool Authentifier(Login pLogin)
        {
            bool isConnect = false;
            foreach (Login unLogin in GetLogins())
            {
                if ((unLogin.loginUser == pLogin.loginUser) && (unLogin.passwordUser == pLogin.passwordUser))
                {
                    isConnect = true;
                }
            }
            return isConnect;
        }

        #endregion
    }
}
