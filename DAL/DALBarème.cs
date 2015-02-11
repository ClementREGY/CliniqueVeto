using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBarème
    {
        #region Create
        public static bool AddBareme(Bareme bareme)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_bareme @code,@dateVigueur,@typeActe,@libelle,@tarifFixe,@tarifMin,@tarifMax,@codeVaccin";
                    command.Parameters.AddWithValue("@code", bareme.codeGroupement);
                    command.Parameters.AddWithValue("@dateVigueur", bareme.dateVigueur);
                    command.Parameters.AddWithValue("@typeActe", bareme.typeActe);
                    command.Parameters.AddWithValue("@libelle", bareme.libelle);
                    command.Parameters.AddWithValue("@tarifFixe", bareme.tarifFixe);
                    command.Parameters.AddWithValue("@tarifMin", bareme.tarifMini);
                    command.Parameters.AddWithValue("@tarifMax", bareme.tarifMaxi);

                    if (bareme.codeVaccin == "")
                        command.Parameters.AddWithValue("@codeVaccin", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@codeVaccin", Guid.Parse(bareme.codeVaccin));

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

        public static List<Bareme> GetBaremes()
        {
            List<Bareme> list = new List<Bareme>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT CodeGroupement, DateVigueur, TypeActe, Libelle, ISNULL(TarifFixe, 0) AS TarifFixe, ISNULL(TarifMini, 0) AS TarifMini, ISNULL(TarifMaxi, 0) AS TarifMaxi, CodeVaccin, Archive FROM Baremes WHERE Archive = 0";

                    SqlDataReader dt = command.ExecuteReader();

                    int colCode = dt.GetOrdinal("CodeGroupement");
                    int colDate = dt.GetOrdinal("DateVigueur");
                    int colType = dt.GetOrdinal("TypeActe");
                    int colLibelle = dt.GetOrdinal("Libelle");
                    int colFixe = dt.GetOrdinal("TarifFixe");
                    int colMini = dt.GetOrdinal("TarifMini");
                    int colMaxi = dt.GetOrdinal("TarifMaxi");
                    int colVaccin = dt.GetOrdinal("CodeVaccin");
                    int colArchive = dt.GetOrdinal("Archive");

                    while (dt.Read())
                    {
                        Bareme bareme = new Bareme();
                        bareme.codeGroupement = dt.GetString(colCode);
                        bareme.dateVigueur = dt.GetString(colDate);
                        bareme.typeActe = dt.GetString(colType);
                        bareme.libelle = dt.GetString(colLibelle);
                        bareme.tarifFixe = dt.GetDecimal(colFixe);
                        bareme.tarifMini = dt.GetDecimal(colMini);
                        bareme.tarifMaxi = dt.GetDecimal(colMaxi);
                        bareme.codeVaccin = (dt.GetValue(colVaccin).ToString() != null) ? dt.GetValue(colVaccin).ToString() : String.Empty;
                        bareme.archive = dt.GetBoolean(colArchive);

                        list.Add(bareme);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static Bareme GetBareme(String libelle)
        {
            Bareme result = new Bareme();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT CodeGroupement, DateVigueur, TypeActe, Libelle, ISNULL(TarifFixe, 0) AS TarifFixe, ISNULL(TarifMini, 0) AS TarifMini, ISNULL(TarifMaxi, 0) AS TarifMaxi, CodeVaccin, Archive FROM Baremes WHERE Libelle LIKE ('%' + @libelle + '%') AND Archive = 0";
                    command.Parameters.AddWithValue("@libelle", libelle);

                    SqlDataReader dt = command.ExecuteReader();

                    int colCode = dt.GetOrdinal("CodeGroupement");
                    int colDate = dt.GetOrdinal("DateVigueur");
                    int colType = dt.GetOrdinal("TypeActe");
                    int colLibelle = dt.GetOrdinal("Libelle");
                    int colFixe = dt.GetOrdinal("TarifFixe");
                    int colMini = dt.GetOrdinal("TarifMini");
                    int colMaxi = dt.GetOrdinal("TarifMaxi");
                    int colVaccin = dt.GetOrdinal("CodeVaccin");
                    int colArchive = dt.GetOrdinal("Archive");

                    while (dt.Read())
                    {
                        result.codeGroupement = dt.GetString(colCode);
                        result.dateVigueur = dt.GetString(colDate);
                        result.typeActe = dt.GetString(colType);
                        result.libelle = dt.GetString(colLibelle);
                        result.tarifFixe = dt.GetDecimal(colFixe);
                        result.tarifMini = dt.GetDecimal(colMini);
                        result.tarifMaxi = dt.GetDecimal(colMaxi);
                        result.codeVaccin = (dt.GetValue(colVaccin).ToString() != null) ? dt.GetValue(colVaccin).ToString() : String.Empty;
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

        public static List<String> GetDateVigueurActe(String libelle)
        {
            List<String> list = new List<String>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT DateVigueur WHERE Libelle LIKE ('%' + @libelle + '%')";
                    command.Parameters.AddWithValue("@libelle", libelle);

                    SqlDataReader dt = command.ExecuteReader();
                    int colDate = dt.GetOrdinal("DateVigueur");

                    while (dt.Read())
                    {
                        list.Add(dt.GetString(colDate));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static List<String> GetLibelleActe(String type)
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

        #region Update

        public static bool SetBaremeArchive(Bareme bareme)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Baremes SET Archive = '1' WHERE CodeGroupement = @code AND DateVigueur = @date";
                    command.Parameters.AddWithValue("@code", bareme.codeGroupement);
                    command.Parameters.AddWithValue("@date", bareme.dateVigueur);

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
