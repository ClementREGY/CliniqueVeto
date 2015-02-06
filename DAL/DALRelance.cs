using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;

namespace DAL
{
    public class DALRelance
    {
        public static List<Relance> GetRelances()
        {
            List<Relance> list = new List<Relance>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT b.DateVigueur, v.NomVaccin, v.PeriodeValidite FROM LignesConsultations lc INNER JOIN Baremes b ON b.CodeGroupement=lc.CodeGroupement INNER JOIN Vaccins v ON v.CodeVaccin=b.CodeVaccin WHERE lc.RappelEnvoye = '0'";

                    SqlDataReader dt = command.ExecuteReader();

                    int colDateVig = dt.GetOrdinal("DateVigueur");
                    int colNom = dt.GetOrdinal("NomVaccin");
                    int colValidite = dt.GetOrdinal("PeriodeValidite");

                    while (dt.Read())
                    {
                        Relance relance = new Relance();
                        relance.dateVigueur = dt.GetString(colDateVig);
                        relance.nomVaccin = dt.GetString(colNom);
                        relance.periodeValidite = dt.GetInt32(colValidite);
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
    }
}
