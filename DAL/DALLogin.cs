using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;

namespace DAL
{
    public class DALLogin
    {
        #region Create

        public static int AddLogin(Login login)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_login @login, @password, 0;";
                    command.Parameters.AddWithValue("@login", login.loginUser);
                    command.Parameters.AddWithValue("@password", login.passwordUser);

                    Decimal dResult = (decimal)command.ExecuteScalar();
                    int resultat = (int)dResult;

                    return resultat;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
        }

        #endregion

        #region Read

        public static List<Login> GetLogins()
        {
            List<Login> list = new List<Login>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Logins ORDER BY Login";

                    SqlDataReader dt = command.ExecuteReader();

                    int colId = dt.GetOrdinal("Id");
                    int colLogin = dt.GetOrdinal("Login");
                    int colPassword = dt.GetOrdinal("Password");

                    while (dt.Read())
                    {
                        Login login = new Login();
                        login.loginUser = dt.GetString(colLogin);
                        login.passwordUser = dt.GetString(colPassword);
                        login.id = dt.GetInt32(colId);
                        list.Add(login);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static Login GetLogin(int IdLogin)
        {
            Login login = new Login();
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Logins WHERE ID = @id";
                    command.Parameters.AddWithValue("@id", IdLogin);

                    SqlDataReader dt = command.ExecuteReader();

                    int colId = dt.GetOrdinal("Id");
                    int colLogin = dt.GetOrdinal("Login");
                    int colPassword = dt.GetOrdinal("Password");

                    while (dt.Read())
                    {
                        login.loginUser = dt.GetString(colLogin);
                        login.passwordUser = dt.GetString(colPassword);
                        login.id = dt.GetInt32(colId);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return login;
        }

        #endregion

        #region Update

        public static bool SetLogin(Login login)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Logins SET Login = @login, Password = @password WHERE Id = @Id";
                    command.Parameters.AddWithValue("@login", login.loginUser);
                    command.Parameters.AddWithValue("@password", login.passwordUser);
                    command.Parameters.AddWithValue("@id", login.id);

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

        public static bool DeleteLogin(Login login)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "DELETE FROM Logins WHERE Id = @Id";
                    command.Parameters.AddWithValue("@id", login.id);

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

        #region Authentifier
        public static bool Authentifier(Login pLogin)
        {
            bool isConnect = false;
            using (SqlConnection cnx = DALAccess.GetConnection())
            {
                SqlCommand command = cnx.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM Logins WHERE Login = @login, Password = @password";
                command.Parameters.AddWithValue("@login", pLogin.loginUser);
                command.Parameters.AddWithValue("@password", pLogin.passwordUser);

                int resultat = command.ExecuteNonQuery();
                if (resultat == 1)
                    isConnect = true;
                    
            }
            return isConnect;
        }


        #endregion
    }
}
