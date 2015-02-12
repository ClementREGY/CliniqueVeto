using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRace
    {
        #region Create

        public static bool AddRace(Race laRace)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_race @race ,@espece";
                    command.Parameters.AddWithValue("@race", laRace.race);
                    command.Parameters.AddWithValue("@espece", laRace.espece);
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

        public static List<String> GetEspeces()
        {
            List<String> list = new List<String>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT DISTINCT Espece FROM Races";

                    SqlDataReader dt = command.ExecuteReader();
                    int colEspece = dt.GetOrdinal("Espece");

                    while (dt.Read())
                    {
                        list.Add(dt.GetString(colEspece));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static List<String> GetRaces(String espece)
        {
            List<String> list = new List<String>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT DISTINCT Race FROM Races WHERE Espece = @espece";
                    command.Parameters.AddWithValue("@espece", espece);

                    SqlDataReader dt = command.ExecuteReader();
                    int colRace = dt.GetOrdinal("Race");

                    while (dt.Read())
                    {
                        list.Add(dt.GetString(colRace));
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
