using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConsultation
    {
        #region Read

        public static List<RendezVous> GetAgendaByVeterinaire(Guid codeVeto, DateTime laDate)
        {
            List<RendezVous> list = new List<RendezVous>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT A.DateRdv, C.NomClient, C.PrenomClient, An.NomAnimal, V.NomVeto, A.Urgence FROM Agendas A INNER JOIN Veterinaires V ON A.CodeVeto = V.CodeVeto JOIN Animaux An ON A.CodeAnimal = An.CodeAnimal JOIN Clients C ON An.CodeClient = C.CodeClient WHERE A.CodeVeto = @codeVeto AND CONVERT(CHAR(10), A.DateRdv, 103) = @date ORDER BY A.DateRdv";
                    command.Parameters.AddWithValue("@codeVeto", codeVeto);
                    command.Parameters.AddWithValue("@date", laDate.Date);

                    SqlDataReader dt = command.ExecuteReader();

                    int colDate = dt.GetOrdinal("DateRdv");
                    int colNomClient = dt.GetOrdinal("NomClient");
                    int colPrenomClient = dt.GetOrdinal("PrenomClient");
                    int colNomAnimal = dt.GetOrdinal("NomAnimal");
                    int colNomVeto = dt.GetOrdinal("NomVeto");
                    int colUrgence = dt.GetOrdinal("Urgence");

                    while (dt.Read())
                    {
                        RendezVous RDV = new RendezVous();
                        RDV.dateRDV = dt.GetDateTime(colDate);
                        RDV.nomClient = dt.GetString(colNomClient);
                        RDV.prenomClient = dt.GetString(colPrenomClient);
                        RDV.nomAnimal = dt.GetString(colNomAnimal);
                        RDV.nomVeto = dt.GetString(colNomVeto);
                        RDV.urgence = dt.GetBoolean(colUrgence);
                        list.Add(RDV);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        #endregion
    }
}
