using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;

namespace DAL
{
    public class DALClient
    {
        private static List<Client> builderObject(SqlDataReader dt)
        {
            List<Client> list = new List<Client>();
            int colId = dt.GetOrdinal("CodeClient");
            int colNom = dt.GetOrdinal("NomClient");
            int colPrenom = dt.GetOrdinal("PrenomClient");
            int colAdresse = dt.GetOrdinal("Adresse1");
            int colAdresse2 = dt.GetOrdinal("Adresse2");
            int colCP = dt.GetOrdinal("CodePostal");
            int colVille = dt.GetOrdinal("Ville");
            int colNumTel = dt.GetOrdinal("NumTel");
            int colAssurance = dt.GetOrdinal("Assurance");
            int colEmail = dt.GetOrdinal("Email");
            int colRemarque = dt.GetOrdinal("Remarque");
            int colArchive = dt.GetOrdinal("Archive");

            while (dt.Read())
            {
                Client client = new Client();
                client.codeClient = dt.GetGuid(colId);
                client.nomClient = dt.GetString(colNom);
                client.prenomClient = dt.GetString(colPrenom);
                client.adresse = dt.GetString(colAdresse);
                client.adresse2 = (dt.GetValue(colAdresse2).ToString() != null) ? dt.GetValue(colAdresse2).ToString() : String.Empty;
                client.cp = dt.GetString(colCP);
                client.ville = dt.GetString(colVille);
                client.numTel = (dt.GetValue(colNumTel).ToString() != null) ? dt.GetValue(colNumTel).ToString() : String.Empty;
                client.assurance = (dt.GetValue(colAssurance).ToString() != null) ? dt.GetValue(colAssurance).ToString() : String.Empty;
                client.email = (dt.GetValue(colEmail).ToString() != null) ? dt.GetValue(colEmail).ToString() : String.Empty;
                client.remarque = (dt.GetValue(colRemarque).ToString() != null) ? dt.GetValue(colRemarque).ToString() : String.Empty;
                client.archive = dt.GetBoolean(colArchive);
                list.Add(client);
            }
            return list;
        }

        public static bool AddClient(Client client)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_client @nom, @prenom, @add, @add2, @cp, @ville, @tel, @ass, @mail, @arch";
                    command.Parameters.AddWithValue("@nom", client.nomClient);
                    command.Parameters.AddWithValue("@prenom", client.prenomClient);
                    command.Parameters.AddWithValue("@add", client.adresse);
                    command.Parameters.AddWithValue("@add2", client.adresse2);
                    command.Parameters.AddWithValue("@cp", client.cp);
                    command.Parameters.AddWithValue("@ville", client.ville);
                    command.Parameters.AddWithValue("@tel", client.numTel);
                    command.Parameters.AddWithValue("@ass", client.assurance);
                    command.Parameters.AddWithValue("@mail", client.email);
                    command.Parameters.AddWithValue("@arch", (client.archive != false) ? 1 : 0);
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

        public static List<Client> GetClients()
        {
            List<Client> list = new List<Client>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Clients WHERE Archive = 0 ORDER BY NomClient";

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

        public static Client GetClient(int id)
        {
            List<Client> list = new List<Client>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Clients WHERE Id = @id AND Archive = 0";
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader dt = command.ExecuteReader();
                    list = builderObject(dt);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            if (list.Count > 0)
            {
                return list.First();
            }
            else
            {
                return null;
            }
        }

        public static bool SetClient(Client client)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Clients SET Nom = @nom, Prenom = @prenom, Adresse1 = @adresse, Adresse2 = @adresse2, CodePostal = @cp, Ville = @ville WHERE CodeClient = @id";
                    command.Parameters.AddWithValue("@nom", client.nomClient);
                    command.Parameters.AddWithValue("@prenom", client.prenomClient);
                    command.Parameters.AddWithValue("@adresse", client.adresse);
                    command.Parameters.AddWithValue("@adresse2", client.adresse2);
                    command.Parameters.AddWithValue("@cp", client.cp);
                    command.Parameters.AddWithValue("@ville", client.ville);
                    command.Parameters.AddWithValue("@id", client.codeClient);

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

        public static bool DeleteClient(Client client)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "DELETE FROM Clients WHERE CodeClient = @id";
                    command.Parameters.AddWithValue("@id", client.codeClient.ToString().ToUpper());

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
