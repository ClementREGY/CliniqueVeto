using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtRendezVous
    {
        #region Méthodes CRUD

        // Create
        public static bool CreateRDV(RendezVous pRDV)
        {
            return DALRendezVous.AddRDV(pRDV);
        }

        // Read
        public static List<RendezVous> GetAgendaByVeterinaire(Guid IdVeto, DateTime laDate)
        {
            return DALRendezVous.GetAgendaByVeterinaire(IdVeto, laDate);
        }

        #endregion

    }
}
