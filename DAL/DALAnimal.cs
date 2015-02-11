using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace DAL
{
    public class DALAnimal
    {
        #region Builder

        private static List<Animal> builderObject(SqlDataReader dt)
        {
            List<Animal> list = new List<Animal>();
            int colId = dt.GetOrdinal("CodeAnimal");
            int colNom = dt.GetOrdinal("NomAnimal");
            int colSexe = dt.GetOrdinal("Sexe");
            int colCouleur = dt.GetOrdinal("Couleur");
            int colRace = dt.GetOrdinal("Race");
            int colEspece = dt.GetOrdinal("Espece");
            int colClient = dt.GetOrdinal("CodeClient");
            int colTatouage = dt.GetOrdinal("Tatouage");
            int colAntecedents = dt.GetOrdinal("Antecedents");

            while (dt.Read())
            {
                Animal animal = new Animal();
                animal.codeAnimal = dt.GetGuid(colId);
                animal.nomAnimal = dt.GetString(colNom);
                animal.sexe = dt.GetString(colSexe);
                animal.couleur = (dt.GetValue(colCouleur).ToString() != null) ? dt.GetValue(colCouleur).ToString() : String.Empty;
                animal.race = dt.GetString(colRace);
                animal.espece = dt.GetString(colEspece);
                animal.client = dt.GetGuid(colClient);
                animal.tatouage = (dt.GetValue(colTatouage).ToString() != null) ? dt.GetValue(colTatouage).ToString() : String.Empty;
                animal.antecedents = (dt.GetValue(colAntecedents).ToString() != null) ? dt.GetValue(colAntecedents).ToString() : String.Empty;
                list.Add(animal);
            }
            return list;
        }

        #endregion

        #region Create

        public static bool AddAnimal(Animal animal, Client client)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_animal @nomCli,@prenomCli,@nom,@sexe,@couleur,@espece,@race,@tatouage,@arch";
                    command.Parameters.AddWithValue("@nomCli", client.nomClient);
                    command.Parameters.AddWithValue("@prenomCli", client.prenomClient);
                    command.Parameters.AddWithValue("@nom", animal.nomAnimal);
                    command.Parameters.AddWithValue("@sexe", animal.sexe);
                    command.Parameters.AddWithValue("@couleur", animal.couleur);
                    command.Parameters.AddWithValue("@espece", animal.espece);
                    command.Parameters.AddWithValue("@race", animal.race);
                    command.Parameters.AddWithValue("@tatouage", animal.tatouage);
                    command.Parameters.AddWithValue("@arch", (animal.archive != false) ? 1 : 0);
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

        public static List<Animal> GetAnimals()
        {
            List<Animal> list = new List<Animal>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Animaux WHERE Archive = 0";

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

        public static List<Animal> GetAnimalsByClient(Guid id)
        {
            List<Animal> list = new List<Animal>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Animaux WHERE CodeClient = @id AND Archive = 0";
                    command.Parameters.AddWithValue("@id", id);

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

        public static Animal GetAnimal(Guid id)
        {
            List<Animal> list = new List<Animal>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Animaux WHERE CodeAnimal = @id AND Archive = 0";
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader dt = command.ExecuteReader();
                    list = builderObject(dt);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            if (list.Count > 0)
            {
                return list.First();
            }
            else
            {
                return null;
            }
        }

        public static List<String> GetEspeces()
        {
            List<String> list = new List<String>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT DISTINCT Espece FROM Races";

                    SqlDataReader dt = command.ExecuteReader();
                    int colEspece = dt.GetOrdinal("Espece");

                    while (dt.Read())
                    {
                        list.Add(dt.GetString(colEspece));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erreur : " + ex.Message);
            }
            return list;
        }

        public static List<String> GetRaces(String espece)
        {
            List<String> list = new List<String>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT DISTINCT Race FROM Races WHERE Espece = @espece";
                    command.Parameters.AddWithValue("@espece", espece);

                    SqlDataReader dt = command.ExecuteReader();
                    int colRace = dt.GetOrdinal("Race");

                    while (dt.Read())
                    {
                        list.Add(dt.GetString(colRace));
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

        public static bool SetAnimal(Animal animal)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Animaux SET NomAnimal = @nom, Sexe = @sexe, Couleur = @couleur, Race = @race, Espece = @espece, CodeClient = @codeClient, Tatouage = @tatouage WHERE CodeAnimal = @id";
                    command.Parameters.AddWithValue("@nom", animal.nomAnimal);
                    command.Parameters.AddWithValue("@sexe", animal.sexe);
                    command.Parameters.AddWithValue("@couleur", animal.couleur);
                    command.Parameters.AddWithValue("@race", animal.race);
                    command.Parameters.AddWithValue("@espece", animal.espece);
                    command.Parameters.AddWithValue("@codeClient", animal.client);
                    command.Parameters.AddWithValue("@tatouage", animal.tatouage);
                    command.Parameters.AddWithValue("@id", animal.codeAnimal);

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

        public static bool SetTatouage(String tatouage, Guid codeAnimal)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Animaux SET Tatouage = @tatouage WHERE CodeAnimal = @id";
                    command.Parameters.AddWithValue("@tatouage", tatouage);
                    command.Parameters.AddWithValue("@id", codeAnimal);

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

        public static bool DeleteAnimal(Guid id)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Animaux SET Archive = 1 WHERE CodeAnimal = @id";
                    command.Parameters.AddWithValue("@id", id);

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

        public static bool DeleteAnimalByClient(Client leClient)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE Animaux SET Archive = 1 WHERE CodeClient = @codeClient";
                    command.Parameters.AddWithValue("@codeClient", leClient.codeClient);

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
