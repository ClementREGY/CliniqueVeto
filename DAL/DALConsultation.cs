using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConsultation
    {
        #region Read

        public static List<Consultation> GetConsultations()
        {
            List<Consultation> list = new List<Consultation>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Consultations WHERE Archive = 0";

                    SqlDataReader dt = command.ExecuteReader();

                    int colCode = dt.GetOrdinal("CodeConsultation");
                    int colDate = dt.GetOrdinal("DateConsultation");
                    int colVeto = dt.GetOrdinal("CodeVeto");
                    int colAnimal = dt.GetOrdinal("CodeAnimal");
                    int colCommentaire = dt.GetOrdinal("Commentaire");
                    int colEtat = dt.GetOrdinal("Etat");
                    int colFacture = dt.GetOrdinal("NumFacture");
                    int colArchive = dt.GetOrdinal("Archive");

                    while (dt.Read())
                    {
                        Consultation consult = new Consultation();
                        consult.codeConsultation = dt.GetGuid(colCode);
                        consult.dateConsultation = dt.GetDateTime(colDate);
                        consult.codeVeto = dt.GetGuid(colVeto);
                        consult.codeAnimal = dt.GetGuid(colAnimal);
                        consult.commentaire = (dt.GetValue(colCommentaire).ToString() != null) ? dt.GetValue(colCommentaire).ToString() : String.Empty;
                        consult.etat = dt.GetInt32(colEtat);
                        consult.numFacture = (dt.GetValue(colFacture).ToString() != null) ? dt.GetValue(colFacture).ToString() : String.Empty;
                        consult.archive = dt.GetBoolean(colArchive);

                        list.Add(consult);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static List<Consultation> GetConsultationsByAnimal(Guid codeAnimal)
        {
            List<Consultation> list = new List<Consultation>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Consultations WHERE Archive = 0 AND CodeAnimal = @codeAnimal ORDER BY DateConsultation DESC";
                    command.Parameters.AddWithValue("@codeAnimal", codeAnimal);

                    SqlDataReader dt = command.ExecuteReader();

                    int colCode = dt.GetOrdinal("CodeConsultation");
                    int colDate = dt.GetOrdinal("DateConsultation");
                    int colVeto = dt.GetOrdinal("CodeVeto");
                    int colAnimal = dt.GetOrdinal("CodeAnimal");
                    int colCommentaire = dt.GetOrdinal("Commentaire");
                    int colEtat = dt.GetOrdinal("Etat");
                    int colFacture = dt.GetOrdinal("NumFacture");
                    int colArchive = dt.GetOrdinal("Archive");

                    while (dt.Read())
                    {
                        Consultation consult = new Consultation();
                        consult.codeConsultation = dt.GetGuid(colCode);
                        consult.dateConsultation = dt.GetDateTime(colDate);
                        consult.codeVeto = dt.GetGuid(colVeto);
                        consult.codeAnimal = dt.GetGuid(colAnimal);
                        consult.commentaire = (dt.GetValue(colCommentaire).ToString() != null) ? dt.GetValue(colCommentaire).ToString() : String.Empty;
                        consult.etat = dt.GetInt32(colEtat);
                        consult.numFacture = (dt.GetValue(colFacture).ToString() != null) ? dt.GetValue(colFacture).ToString() : String.Empty;
                        consult.archive = dt.GetBoolean(colArchive);

                        list.Add(consult);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static Consultation GetConsultation(Guid codeConsult)
        {
            Consultation result = new Consultation();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Consultations WHERE CodeConsultation = @codeConsult Archive = 0";
                    command.Parameters.AddWithValue("@codeConsult", codeConsult);

                    SqlDataReader dt = command.ExecuteReader();

                    int colCode = dt.GetOrdinal("CodeConsultation");
                    int colDate = dt.GetOrdinal("DateConsultation");
                    int colVeto = dt.GetOrdinal("CodeVeto");
                    int colAnimal = dt.GetOrdinal("CodeAnimal");
                    int colCommentaire = dt.GetOrdinal("Commentaire");
                    int colEtat = dt.GetOrdinal("Etat");
                    int colFacture = dt.GetOrdinal("NumFacture");
                    int colArchive = dt.GetOrdinal("Archive");

                    while (dt.Read())
                    {
                        result.codeConsultation = dt.GetGuid(colCode);
                        result.dateConsultation = dt.GetDateTime(colDate);
                        result.codeVeto = dt.GetGuid(colVeto);
                        result.codeAnimal = dt.GetGuid(colAnimal);
                        result.commentaire = (dt.GetValue(colCommentaire).ToString() != null) ? dt.GetValue(colCommentaire).ToString() : String.Empty;
                        result.etat = dt.GetInt32(colEtat);
                        result.numFacture = (dt.GetValue(colFacture).ToString() != null) ? dt.GetValue(colFacture).ToString() : String.Empty;
                        result.archive = dt.GetBoolean(colArchive);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return result;
        }

        public static List<String> GetTypesActes()
        {
            List<String> list = new List<String>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT DISTINCT TypeActe FROM Baremes";

                    SqlDataReader dt = command.ExecuteReader();
                    int colType = dt.GetOrdinal("TypeActe");

                    while (dt.Read())
                    {
                        list.Add(dt.GetString(colType));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static List<String> GetLibellesActes(String type)
        {
            List<String> list = new List<String>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT DISTINCT Libelle FROM Baremes WHERE TypeActe = @type";
                    command.Parameters.AddWithValue("@type", type);

                    SqlDataReader dt = command.ExecuteReader();
                    int colLibelle = dt.GetOrdinal("Libelle");

                    while (dt.Read())
                    {
                        list.Add(dt.GetString(colLibelle));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static List<Decimal> GetTarifsActes(String libelle)
        {
            List<Decimal> list = new List<Decimal>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT ISNULL(TarifFixe, 0) AS TarifFixe, ISNULL(TarifMini, 0) AS TarifMini, ISNULL(TarifMaxi, 0) AS TarifMaxi FROM Baremes WHERE Libelle LIKE ('%' + @libelle + '%')";
                    command.Parameters.AddWithValue("@libelle", libelle);

                    SqlDataReader dt = command.ExecuteReader();
                    int colFixe = dt.GetOrdinal("TarifFixe");
                    int colMini = dt.GetOrdinal("TarifMini");
                    int colMaxi = dt.GetOrdinal("TarifMaxi");

                    while (dt.Read())
                    {
                        list.Add(dt.GetDecimal(colFixe));
                        list.Add(dt.GetDecimal(colMini));
                        list.Add(dt.GetDecimal(colMaxi));
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
