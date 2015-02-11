using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALActe
    {
        #region Create

        public static bool AddActe(Acte acte)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_acte @codeConsultation, @codeGroupement, @datevigueur, @prix";
                    command.Parameters.AddWithValue("@codeConsultation", acte.numConsultation);
                    command.Parameters.AddWithValue("@codeGroupement", acte.codeGroupement);
                    command.Parameters.AddWithValue("@datevigueur", acte.dateVigueur);
                    command.Parameters.AddWithValue("@prix", acte.prix);

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

        public static List<Acte> GetActesByConsultation(Guid codeConsult)
        {
            List<Acte> list = new List<Acte>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT LC.CodeConsultation, LC.NumLigne, LC.CodeGroupement, LC.DateVigueur, LC.Prix, B.TypeActe, B.Libelle FROM LignesConsultations LC JOIN Baremes B ON LC.CodeGroupement = B.CodeGroupement WHERE CodeConsultation = @codeConsultation AND LC.Archive = 0;";
                    command.Parameters.AddWithValue("@codeConsultation", codeConsult);

                    SqlDataReader dt = command.ExecuteReader();

                    int colCode = dt.GetOrdinal("CodeConsultation");
                    int colActe = dt.GetOrdinal("NumLigne");
                    int colGroup = dt.GetOrdinal("CodeGroupement");
                    int colDateVigueur = dt.GetOrdinal("DateVigueur");
                    int colPrix = dt.GetOrdinal("Prix");
                    int colType = dt.GetOrdinal("TypeActe");
                    int colLibelle = dt.GetOrdinal("Libelle");

                    while (dt.Read())
                    {
                        Acte acte = new Acte();
                        acte.numConsultation = dt.GetGuid(colCode);
                        acte.numActe = dt.GetGuid(colActe);
                        acte.codeGroupement = dt.GetString(colGroup);
                        acte.dateVigueur = dt.GetString(colDateVigueur);
                        acte.prix = dt.GetDecimal(colPrix);
                        acte.typeActe = dt.GetString(colType);
                        acte.libelle = dt.GetString(colLibelle);

                        list.Add(acte);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static Acte GetActe(Guid codeActe)
        {
            Acte result = new Acte();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT LC.CodeConsultation, LC.NumLigne, LC.CodeGroupement, LC.DateVigueur, LC.Prix, B.TypeActe, B.Libelle FROM LignesConsultations LC JOIN Baremes B ON LC.CodeGroupement = B.CodeGroupement WHERE LC.NumLigne = @codeActe AND LC.Archive = 0;";
                    command.Parameters.AddWithValue("@codeActe", codeActe);

                    SqlDataReader dt = command.ExecuteReader();

                    int colCode = dt.GetOrdinal("CodeConsultation");
                    int colActe = dt.GetOrdinal("NumLigne");
                    int colGroup = dt.GetOrdinal("CodeGroupement");
                    int colDateVigueur = dt.GetOrdinal("DateVigueur");
                    int colPrix = dt.GetOrdinal("Prix");
                    int colType = dt.GetOrdinal("TypeActe");
                    int colLibelle = dt.GetOrdinal("Libelle");

                    while (dt.Read())
                    {
                        result.numConsultation = dt.GetGuid(colCode);
                        result.numActe = dt.GetGuid(colActe);
                        result.codeGroupement = dt.GetString(colGroup);
                        result.dateVigueur = dt.GetString(colDateVigueur);
                        result.prix = dt.GetDecimal(colPrix);
                        result.typeActe = dt.GetString(colType);
                        result.libelle = dt.GetString(colLibelle);
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
