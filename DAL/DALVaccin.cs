using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;

namespace DAL
{
    public class DALVaccin
    {
        private static List<Vaccin> builderObject(SqlDataReader dt)
        {
            List<Vaccin> list = new List<Vaccin>();
            int colCode = dt.GetOrdinal("CodeVaccin");
            int colNom = dt.GetOrdinal("NomVaccin");
            int colQuantite = dt.GetOrdinal("QuantiteStock");
            int colValidite = dt.GetOrdinal("PeriodeValidite");
            
            while (dt.Read())
            {
                Vaccin vaccin = new Vaccin();
                vaccin.codeVaccin = dt.GetGuid(colCode);
                vaccin.nomVaccin = dt.GetString(colNom);
                vaccin.quantiteStock = dt.GetInt32(colQuantite);
                vaccin.periodeValidite = dt.GetInt32(colValidite);
                
                list.Add(vaccin);
            }
            return list;
        }

        public static Guid AddVaccin(Vaccin leVaccin)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_vaccin @nomvaccin, @periodevalidite, @quantite";
                    command.Parameters.AddWithValue("@nomvaccin", leVaccin.nomVaccin);
                    command.Parameters.AddWithValue("@periodevalidite", leVaccin.periodeValidite);
                    command.Parameters.AddWithValue("@quantite", leVaccin.quantiteStock);

                    Guid dResult = (Guid)command.ExecuteScalar();
                    return dResult;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
        }

        public static List<Vaccin> GetVaccins()
        {
            List<Vaccin> list = new List<Vaccin>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Vaccins WHERE Archive = 0 ORDER BY QuantiteStock";

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

        public static bool SetVaccin(Vaccin vaccin)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Vaccins SET QuantiteStock = @quantite WHERE CodeVaccin = @code";
                    command.Parameters.AddWithValue("@code", vaccin.codeVaccin);
                    command.Parameters.AddWithValue("@quantite", vaccin.quantiteStock);
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
