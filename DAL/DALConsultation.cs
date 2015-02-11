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
        #region Create

        public static Guid AddConsultation(Consultation consultation)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_consultation @dateconsultation, @codeVeto, @codeAnimal, @commentaire";
                    command.Parameters.AddWithValue("@dateconsultation", consultation.dateConsultation);
                    command.Parameters.AddWithValue("@codeVeto", consultation.codeVeto);
                    command.Parameters.AddWithValue("@codeAnimal", consultation.codeAnimal);
                    command.Parameters.AddWithValue("@commentaire", consultation.commentaire == null ? String.Empty : consultation.commentaire);

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

        public static List<Consultation> GetConsultations()
        {
            List<Consultation> list = new List<Consultation>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT C.CodeConsultation, C.DateConsultation, C.CodeVeto, C.CodeAnimal, C.Commentaire, C.Etat, C.NumFacture, C.Archive, V.NomVeto, CL.NomClient + ' ' + Cl.PrenomClient AS Client, A.NomAnimal FROM Veterinaires V JOIN Consultations C ON V.CodeVeto = C.CodeVeto JOIN Animaux A ON C.CodeAnimal = A.CodeAnimal JOIN Clients Cl ON A.CodeClient = Cl.CodeClient WHERE C.Archive = 0 AND C.Etat = 1";

                    SqlDataReader dt = command.ExecuteReader();

                    int colCode = dt.GetOrdinal("CodeConsultation");
                    int colDate = dt.GetOrdinal("DateConsultation");
                    int colVeto = dt.GetOrdinal("CodeVeto");
                    int colNomVeto = dt.GetOrdinal("NomVeto");
                    int colNomClient = dt.GetOrdinal("Client");
                    int colAnimal = dt.GetOrdinal("CodeAnimal");
                    int colNomAnimal = dt.GetOrdinal("NomAnimal");
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
                        consult.nomVeto = dt.GetString(colNomVeto);
                        consult.codeAnimal = dt.GetGuid(colAnimal);
                        consult.nomAnimal = dt.GetString(colNomAnimal);
                        consult.nomClient = dt.GetString(colNomClient);
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
                    command.CommandText = "SELECT * FROM Consultations WHERE CodeConsultation = @codeConsult AND Archive = 0";
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

        #endregion
    }
}
