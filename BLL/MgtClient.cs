using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class MgtClient
    {
        #region Méthodes CRUD

        // Create
        public static Guid CreateClient(Client pClient)
        {
            return DALClient.AddClient(pClient);
        }

        // Read
        public static List<Client> GetClients()
        {
            return DALClient.GetClients();
        }

        public static Client GetClient(Guid IdClient)
        {
            return DALClient.GetClient(IdClient);
        }

        // Update
        public static bool UpdateClient(Client pClient)
        {
            return DALClient.SetClient(pClient);
        }

        // Delete
        public static bool DeleteClient(Client pClient)
        {
            return DALClient.DeleteClient(pClient);
        }

        #endregion
    }
}
