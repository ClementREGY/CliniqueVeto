using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;

namespace DAL
{
    class DALClient
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
                client.adresse2 = dt.GetString(colAdresse2);
                client.cp = dt.GetString(colCP);
                client.ville = dt.GetString(colVille);
                client.numTel = dt.GetString(colNumTel);
                client.assurance = dt.GetString(colAssurance);
                client.email = dt.GetString(colEmail);
                client.remarque = dt.GetString(colRemarque);
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
                    command.CommandText = "EXEC ajout_client @nom,@prenom,@adresse,@adresse2,@cp,@ville";
                    command.Parameters.AddWithValue("@nom", client.nomClient);
                    command.Parameters.AddWithValue("@prenom", client.prenomClient);
                    command.Parameters.AddWithValue("@adresse", client.adresse);
                    command.Parameters.AddWithValue("@adresse2", client.adresse2);
                    command.Parameters.AddWithValue("@cp", client.cp);
                    command.Parameters.AddWithValue("@ville", client.ville);
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
                    command.CommandText = "SELECT * FROM Clients ORDER BY Nom";

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

        public static Client GetClient(Client client)
        {
            List<Client> list = new List<Client>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Clients WHERE Id = @id";
                    command.Parameters.AddWithValue("@id", client.codeClient);
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
                    command.CommandText = "DELETE FROM Clients WHERE Id = @id";
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
    }
}
