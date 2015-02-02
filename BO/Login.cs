using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Login
    {
        public Login(String LoginUser, String PasswordUser, int Id)
        {
            this.LoginUser = LoginUser;
            this.PasswordUser = PasswordUser;
            this.Id = Id;
        }

        public Login()
        {
        }

        public String LoginUser { get; set; }
        public String PasswordUser { get; set; }
        public int Id { get; set; }
    }
}
