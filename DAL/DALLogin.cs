﻿using System;
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
        public static bool AddLogin(Login login)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT INTO Logins VALUES(@login,@password)";
                    command.Parameters.AddWithValue("@login", login.LoginUser);
                    command.Parameters.AddWithValue("@password", login.PasswordUser);
                    int resultat = command.ExecuteNonQuery();
                    if (resultat == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
        }

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
                        login.LoginUser = dt.GetString(colLogin);
                        login.PasswordUser = dt.GetString(colPassword);
                        login.Id = dt.GetInt32(colId);
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

        public static bool SetLogin(Login login)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Logins SET Login = @login, Password = @password WHERE Id = @Id";
                    command.Parameters.AddWithValue("@login", login.LoginUser);
                    command.Parameters.AddWithValue("@password", login.PasswordUser);
                    command.Parameters.AddWithValue("@id", login.Id);

                    int resultat = command.ExecuteNonQuery();
                    if (resultat == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
        }

        public static bool DeleteLogin(Login login)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "DELETE Login WHERE Id = @Id";
                    command.Parameters.AddWithValue("@id", login.Id);

                    int resultat = command.ExecuteNonQuery();
                    if (resultat == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
        }
    }
}