﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DALAccess
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["ConnexionPrincipale"].ToString();
                cnx.Open();
            }
            catch (Exception)
            {
                throw new ApplicationException("Erreur à l'ouverture de la connexion");
            }
            return cnx;
        }
    }
}
