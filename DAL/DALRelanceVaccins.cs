using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;

namespace DAL
{
    public class DALRelanceVaccins
    {
        #region Read
        public static List<RelanceVaccins> GetRelances()
        {
            List<RelanceVaccins> list = new List<RelanceVaccins>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM VueRelance WHERE RappelEnvoye = 'false'";

                    SqlDataReader dt = command.ExecuteReader();

                    int colCodeCons = dt.GetOrdinal("CodeConsultation");
                    int colNumLigne = dt.GetOrdinal("NumLigne");
                    int colDateVig = dt.GetOrdinal("DateVigueur");
                    int colNom = dt.GetOrdinal("NomVaccin");
                    int colValidite = dt.GetOrdinal("PeriodeValidite");
                    int colNomAnimal = dt.GetOrdinal("NomAnimal");
                    int colNomCli = dt.GetOrdinal("NomClient");
                    int colPrenomCli = dt.GetOrdinal("PrenomClient");

                    while (dt.Read())
                    {
                        RelanceVaccins relance = new RelanceVaccins();
                        relance.codeConsultation = dt.GetGuid(colCodeCons);
                        relance.numLigne = dt.GetGuid(colNumLigne);
                        string dateVigueur = dt.GetString(colDateVig);
                        relance.dateVigueur = Convert.ToDateTime(dateVigueur);
                        relance.nomVaccin = dt.GetString(colNom);
                        relance.periodeValidite = dt.GetInt32(colValidite);
                        relance.nomAnimal = dt.GetString(colNomAnimal);
                        relance.nomClient = dt.GetString(colNomCli);
                        relance.prenomClient = dt.GetString(colPrenomCli);

                        DateTime now = DateTime.Now;
                        DateTime dateV = relance.dateVigueur;
                        DateTime dateEcheance = dateV.AddMonths(relance.periodeValidite - 1).AddDays(14);

                        if (now > dateEcheance)
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
        public static bool SetRelanceEnvoye(RelanceVaccins relance)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE LignesConsultations SET RappelEnvoye='1' WHERE CodeConsultation=@Code AND NumLigne=@Num";
                    command.Parameters.AddWithValue("@Code", relance.codeConsultation);
                    command.Parameters.AddWithValue("@Num", relance.numLigne);

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
