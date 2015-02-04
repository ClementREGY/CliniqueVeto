using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRendezVous
    {
        public static bool AddRDV(RendezVous rdv)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_agenda @nomclient, @prenomclient,	@nomanimal,	@nomveto, @daterdv";
                    command.Parameters.AddWithValue("@nomclient", rdv.nomClient);
                    command.Parameters.AddWithValue("@prenomclient", rdv.prenomClient);
                    command.Parameters.AddWithValue("@nomanimal", rdv.nomAnimal);
                    command.Parameters.AddWithValue("@nomveto", rdv.nomVeto);
                    command.Parameters.AddWithValue("@daterdv", rdv.dateRDV);
                    int resultat = command.ExecuteNonQuery();
                    if (resultat == 0)
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
        }

        public static List<RendezVous> GetAgendaByVeterinaire(Guid codeVeto, DateTime laDate)
        {
            List<RendezVous> list = new List<RendezVous>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT A.DateRdv, C.NomClient, C.PrenomClient, An.NomAnimal, V.NomVeto FROM Agendas A INNER JOIN Veterinaires V ON A.CodeVeto = V.CodeVeto JOIN Animaux An ON A.CodeAnimal = An.CodeAnimal JOIN Clients C ON An.CodeClient = C.CodeClient WHERE A.CodeVeto = @codeVeto AND CONVERT(CHAR(10), A.DateRdv, 103) = @date ORDER BY A.DateRdv";
                    command.Parameters.AddWithValue("@codeVeto", codeVeto);
                    command.Parameters.AddWithValue("@date", laDate.Date);

                    SqlDataReader dt = command.ExecuteReader();

                    int colDate = dt.GetOrdinal("DateRdv");
                    int colNomClient = dt.GetOrdinal("NomClient");
                    int colPrenomClient = dt.GetOrdinal("PrenomClient");
                    int colNomAnimal = dt.GetOrdinal("NomAnimal");
                    int colNomVeto = dt.GetOrdinal("NomVeto");

                    while (dt.Read())
                    {
                        RendezVous RDV = new RendezVous();
                        RDV.dateRDV = dt.GetDateTime(colDate);
                        RDV.nomClient = dt.GetString(colNomClient);
                        RDV.prenomClient = dt.GetString(colPrenomClient);
                        RDV.nomAnimal = dt.GetString(colNomAnimal);
                        RDV.nomVeto = dt.GetString(colNomVeto);
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
    }
}
