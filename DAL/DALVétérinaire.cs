using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALVétérinaire
    {
        private static List<Veterinaire> builderObject(SqlDataReader dt)
        {
            List<Veterinaire> list = new List<Veterinaire>();
            int colID = dt.GetOrdinal("CodeVeto");
            int colNom = dt.GetOrdinal("NomVeto");
            int colArchive = dt.GetOrdinal("Archive");
            int colRefLogin = dt.GetOrdinal("RefLogin");

            while (dt.Read())
            {
                Veterinaire veto = new Veterinaire();
                veto.codeVeto = dt.GetGuid(colID);
                veto.nomVeto = dt.GetString(colNom);
                veto.archive = dt.GetBoolean(colArchive);
                veto.refLogin = dt.GetInt32(colRefLogin);
                list.Add(veto);
            }
            return list;
        }

        public static bool AddVeterinaire(Veterinaire veterinaire)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_veterinaire @nomveto, @archive, @reflogin";
                    command.Parameters.AddWithValue("@nomveto", veterinaire.nomVeto);
                    command.Parameters.AddWithValue("@archive", veterinaire.archive);
                    command.Parameters.AddWithValue("@reflogin", veterinaire.refLogin);
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

        public static List<Veterinaire> GetVeterinaires()
        {
            List<Veterinaire> list = new List<Veterinaire>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Veterinaires WHERE V.Archive = 0 ORDER BY NomVeto";

                    SqlDataReader dt = command.ExecuteReader();
                    list = builderObject(dt);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static List<Veterinaire> GetVeterinairesLogin()
        {
            List<Veterinaire> list = new List<Veterinaire>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT V.NomVeto, L.Password FROM Veterinaires V JOIN Logins L ON V.RefLogin = L.ID WHERE V.Archive = 0 ORDER BY NomVeto";

                    SqlDataReader dt = command.ExecuteReader();

                    int colNom = dt.GetOrdinal("NomVeto");
                    int colPassword = dt.GetOrdinal("Password");

                    while (dt.Read())
                    {
                        Veterinaire veto = new Veterinaire(dt.GetString(colNom), dt.GetString(colPassword));
                        list.Add(veto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static bool SetVeterinaire(Veterinaire veterinaire)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Veterinaires SET NomVeto = @nom WHERE CodeVeto = @id";
                    command.Parameters.AddWithValue("@nom", veterinaire.nomVeto);
                    command.Parameters.AddWithValue("@id", veterinaire.codeVeto);

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

        public static bool DeleteVeterinaire(Veterinaire veterinaire)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Veterinaires SET Archive = 1 WHERE CodeVeto = @id";
                    command.Parameters.AddWithValue("@id", veterinaire.codeVeto.ToString().ToUpper());

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
    }
}
