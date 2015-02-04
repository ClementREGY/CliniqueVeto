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
                    command.CommandText = "SELECT * FROM Veterinaires WHERE Archive = 0 ORDER BY NomVeto";

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

        public static Veterinaire GetVeterinaire(Guid Id)
        {
            Veterinaire veto = new Veterinaire();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Veterinaires WHERE Archive = 0 AND CodeVeto = @id";
                    command.Parameters.AddWithValue("@id", Id);

                    SqlDataReader dt = command.ExecuteReader();

                    int colId = dt.GetOrdinal("CodeVeto");
                    int colNom = dt.GetOrdinal("NomVeto");
                    int colArchive = dt.GetOrdinal("Archive");
                    int colRefLogin = dt.GetOrdinal("RefLogin");

                    while (dt.Read())
                    {
                        veto.nomVeto = dt.GetString(colNom);
                        veto.archive = dt.GetBoolean(colArchive);
                        veto.refLogin = dt.GetInt32(colRefLogin);
                        veto.codeVeto = dt.GetGuid(colId);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return veto;
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
