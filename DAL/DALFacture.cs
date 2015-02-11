﻿using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALFacture
    {
        #region Create

        public static Guid AddFacture(Facture facture)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_facture @DateFact, @nomVeto, @nomanimal, @dateConsultation, @etat";
                    command.Parameters.AddWithValue("@DateFact", facture.dateFacture);
                    command.Parameters.AddWithValue("@nomVeto", facture.nomVeto);
                    command.Parameters.AddWithValue("@nomanimal", facture.nomAnimal);
                    command.Parameters.AddWithValue("@dateConsultation", facture.dateConsult);
                    command.Parameters.AddWithValue("@etat", facture.etat);

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

        public static Facture GetFacture(Guid codeFacture)
        {
            Facture result = new Facture();
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT F.NumFacture, F.DateFacture, F.CodeClient, V.NomVeto, A.NomAnimal, Cl.NomClient + ' ' + Cl.PrenomClient AS Client, C.DateConsultation, F.TotalFacture, F.Archive, F.Etat, F.RappelEnvoye FROM Veterinaires V JOIN Consultations C ON V.CodeVeto = C.CodeVeto JOIN Factures F ON C.NumFacture = F.NumFacture JOIN Clients Cl ON F.CodeClient = Cl.CodeClient JOIN Animaux A ON Cl.CodeClient = A.CodeClient WHERE F.Archive = 0 AND F.NumFacture = @id";
                    command.Parameters.AddWithValue("@id", codeFacture);

                    SqlDataReader dt = command.ExecuteReader();

                    int colNumFacture = dt.GetOrdinal("NumFacture");
                    int colDateFacture = dt.GetOrdinal("DateFacture");
                    int colCodeClient = dt.GetOrdinal("CodeClient");
                    int colNomVeto = dt.GetOrdinal("NomVeto");
                    int colNomAnimal = dt.GetOrdinal("NomAnimal");
                    int colNomClient = dt.GetOrdinal("Client");
                    int colDateConsult = dt.GetOrdinal("DateConsultation");
                    int colTotal = dt.GetOrdinal("TotalFacture");
                    int colArchive = dt.GetOrdinal("Archive");
                    int colEtat = dt.GetOrdinal("Etat");
                    int colRappel = dt.GetOrdinal("RappelEnvoye");

                    while (dt.Read())
                    {
                        result.numFacture = dt.GetGuid(colNumFacture);
                        result.dateFacture = dt.GetDateTime(colDateFacture);
                        result.codeClient = dt.GetGuid(colCodeClient);
                        result.nomVeto = dt.GetString(colNomVeto);
                        result.nomAnimal = dt.GetString(colNomAnimal);
                        result.nomClient = dt.GetString(colNomClient);
                        result.dateConsult = dt.GetDateTime(colDateConsult);
                        result.totalFacture = dt.GetDecimal(colTotal);
                        result.archive = dt.GetBoolean(colArchive);
                        result.etat = dt.GetInt32(colEtat);
                        result.rappelEnvoye = dt.GetDateTime(colRappel);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }

            return result;
        }

        #endregion
    }
}
