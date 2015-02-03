using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Login
    {
        public String loginUser { get; set; }
        public String passwordUser { get; set; }
        public int id { get; set; }

        public Login()
        {
        }

        public Login(String LoginUser, String PasswordUser, int Id = 0)
        {
            this.loginUser = LoginUser;
            this.passwordUser = PasswordUser;
            this.id = Id;
        }
    }
}
