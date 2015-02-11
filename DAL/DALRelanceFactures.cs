using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;

namespace DAL
{
    public class DALRelanceFactures
    {
        #region Read
        public static List<Facture> GetRelances()
        {
            List<Facture> list = new List<Facture>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT F.NumFacture, F.DateFacture, F.CodeClient, V.NomVeto, A.NomAnimal, Cl.NomClient + ' ' + Cl.PrenomClient AS Client, C.DateConsultation, F.TotalFacture, F.Archive, F.Etat, F.RappelEnvoye FROM Veterinaires V JOIN Consultations C ON V.CodeVeto = C.CodeVeto JOIN Factures F ON C.NumFacture = F.NumFacture JOIN Clients Cl ON F.CodeClient = Cl.CodeClient JOIN Animaux A ON Cl.CodeClient = A.CodeClient WHERE F.Etat = '1'";

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
                        Facture relance = new Facture();
                        relance.numFacture = dt.GetGuid(colNumFacture);
                        relance.dateFacture = dt.GetDateTime(colDateFacture);
                        relance.codeClient = dt.GetGuid(colCodeClient);
                        relance.nomVeto = dt.GetString(colNomVeto);
                        relance.nomAnimal = dt.GetString(colNomAnimal);
                        relance.nomClient = dt.GetString(colNomClient);
                        relance.dateConsult = dt.GetDateTime(colDateConsult);
                        relance.totalFacture = dt.GetDecimal(colTotal);
                        relance.archive = dt.GetBoolean(colArchive);
                        relance.etat = dt.GetInt32(colEtat);
                        relance.rappelEnvoye = dt.GetDateTime(colRappel);

                        if ( relance.rappelEnvoye == null && relance.dateFacture.AddMonths(1) <= DateTime.Now )
                            list.Add(relance);
                        else if ( relance.rappelEnvoye != null && ((DateTime)relance.rappelEnvoye).AddMonths(1) <= DateTime.Now )
                            list.Add(relance);
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

        #region Update
        public static bool SetRelanceEnvoye(Facture relance)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE LignesConsultations SET RappelEnvoye=@date WHERE NumFacture=@Num";
                    command.Parameters.AddWithValue("@Num", relance.numFacture);
                    command.Parameters.AddWithValue("@date", relance.rappelEnvoye);

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
