﻿using System;
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
        #region Create

        public static Guid AddClient(Client client)
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

                    Guid dResult = (Guid)command.ExecuteScalar();
                    return dResult;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
        }

        #endregion

        #region Read

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
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static Client GetClient(Guid codeClient)
        {
            Client leClient = new Client();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Clients WHERE codeClient = @codeClient AND Archive = 0";
                    command.Parameters.AddWithValue("@codeClient", codeClient);

                    SqlDataReader dt = command.ExecuteReader();

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
                        leClient.codeClient = dt.GetGuid(colId);
                        leClient.nomClient = dt.GetString(colNom);
                        leClient.prenomClient = dt.GetString(colPrenom);
                        leClient.adresse = dt.GetString(colAdresse);
                        leClient.adresse2 = (dt.GetValue(colAdresse2).ToString() != null) ? dt.GetValue(colAdresse2).ToString() : String.Empty;
                        leClient.cp = dt.GetString(colCP);
                        leClient.ville = dt.GetString(colVille);
                        leClient.numTel = (dt.GetValue(colNumTel).ToString() != null) ? dt.GetValue(colNumTel).ToString() : String.Empty;
                        leClient.assurance = (dt.GetValue(colAssurance).ToString() != null) ? dt.GetValue(colAssurance).ToString() : String.Empty;
                        leClient.email = (dt.GetValue(colEmail).ToString() != null) ? dt.GetValue(colEmail).ToString() : String.Empty;
                        leClient.remarque = (dt.GetValue(colRemarque).ToString() != null) ? dt.GetValue(colRemarque).ToString() : String.Empty;
                        leClient.archive = dt.GetBoolean(colArchive);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return leClient;
        }

        public static bool GetFacturesImpayees(Guid codeClient)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Clients C JOIN Factures F ON C.CodeClient = F.CodeClient WHERE F.Etat != 2 AND F.CodeClient = @codeClient";
                    command.Parameters.AddWithValue("@codeClient", codeClient);

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

        #region Update

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

        #endregion

        #region Delete

        public static bool DeleteClient(Client client)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Clients SET Archive = 1 WHERE CodeClient = @id";
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

        #endregion
    }
}
