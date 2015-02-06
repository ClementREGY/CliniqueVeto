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
        #region Create

        public static bool AddRDV(RendezVous rdv)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_agenda @nomclient, @prenomclient,	@nomanimal,	@nomveto, @daterdv, @urgence";
                    command.Parameters.AddWithValue("@nomclient", rdv.nomClient);
                    command.Parameters.AddWithValue("@prenomclient", rdv.prenomClient);
                    command.Parameters.AddWithValue("@nomanimal", rdv.nomAnimal);
                    command.Parameters.AddWithValue("@nomveto", rdv.nomVeto);
                    command.Parameters.AddWithValue("@daterdv", rdv.dateRDV);
                    command.Parameters.AddWithValue("@urgence", (rdv.urgence != false) ? 1 : 0);
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

        #endregion

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

        public static List<RendezVous> GetAgendaByDate(DateTime laDate)
        {
            List<RendezVous> list = new List<RendezVous>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT A.DateRdv, C.NomClient, C.PrenomClient, An.NomAnimal, V.NomVeto, A.Urgence FROM Agendas A INNER JOIN Veterinaires V ON A.CodeVeto = V.CodeVeto JOIN Animaux An ON A.CodeAnimal = An.CodeAnimal JOIN Clients C ON An.CodeClient = C.CodeClient WHERE CONVERT(CHAR(10), A.DateRdv, 103) = @date ORDER BY A.DateRdv";
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

        public static List<RendezVous> GetAgendaByClient(Guid codeClient, DateTime laDate)
        {
            List<RendezVous> list = new List<RendezVous>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT A.DateRdv, C.NomClient, C.PrenomClient, An.NomAnimal, V.NomVeto, A.Urgence FROM Agendas A INNER JOIN Veterinaires V ON A.CodeVeto = V.CodeVeto JOIN Animaux An ON A.CodeAnimal = An.CodeAnimal JOIN Clients C ON An.CodeClient = C.CodeClient WHERE C.CodeClient = @codeClient AND CONVERT(CHAR(10), A.DateRdv, 103) = @date ORDER BY A.DateRdv";
                    command.Parameters.AddWithValue("@codeClient", codeClient);
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

        #region Delete

        public static bool DeleteRDV(RendezVous rdv)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "DELETE A FROM Agendas A JOIN Veterinaires V ON A.CodeVeto = V.CodeVeto WHERE DateRdv = @dateRDV AND V.NomVeto = @nomVeto";
                    command.Parameters.AddWithValue("@dateRDV", rdv.dateRDV);
                    command.Parameters.AddWithValue("@nomVeto", rdv.nomVeto);

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

        #endregion

        #region Vérification

        public static bool CheckRDV(Guid codeVeto, DateTime laDate)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Agendas WHERE CodeVeto = @codeVeto AND DateRdv = @date";
                    command.Parameters.AddWithValue("@codeVeto", codeVeto);
                    command.Parameters.AddWithValue("@date", laDate);

                    SqlDataReader dt = command.ExecuteReader();

                    int resultat = 0;

                    while (dt.Read())
                        resultat++;

                    if (resultat == 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
        }

        #endregion
    }
}
