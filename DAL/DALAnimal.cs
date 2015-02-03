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
            int colArchive = dt.GetOrdinal("Archive");

            while (dt.Read())
            {
                Animal animal = new Animal();
                animal.codeAnimal = dt.GetGuid(colId);
                animal.nomAnimal = dt.GetString(colNom);
                animal.sexe = dt.GetString(colSexe);
                animal.couleur = dt.GetString(colCouleur);
                animal.race = dt.GetString(colRace);
                animal.espece = dt.GetString(colEspece);
                animal.Client = DALClient.GetClient(dt.GetInt32(colClient));
                animal.tatouage = dt.GetBoolean(colTatouage);
                animal.antecedents = dt.GetString(colAntecedents);
                animal.archive = dt.GetBoolean(colArchive);
                list.Add(animal);
            }
            return list;
        }

        public static bool AddAnimal(Animal animal)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "EXEC ajout_animal @nom,@sexe,@couleur,@race,@espece,@idClient,@tatouage";
                    command.Parameters.AddWithValue("@nom", animal.nomAnimal);
                    command.Parameters.AddWithValue("@sexe", animal.sexe);
                    command.Parameters.AddWithValue("@couleur", animal.couleur);
                    command.Parameters.AddWithValue("@race", animal.race);
                    command.Parameters.AddWithValue("@espece", animal.espece);
                    command.Parameters.AddWithValue("@idClient", animal.Client.codeClient);
                    command.Parameters.AddWithValue("@tatouage", animal.tatouage);
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

        public static List<Animal> GetAnimals()
        {
            List<Animal> list = new List<Animal>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Animaux";

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

        public static List<Animal> GetAnimalsByClient(int id)
        {
            List<Animal> list = new List<Animal>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Animaux WHERE CodeClient = @id";
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

        public static Animal GetAnimal(int id)
        {
            List<Animal> list = new List<Animal>();

            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM Animaux WHERE CodeAnimal = @id";
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
                    command.CommandText = "SELECT DISTINCT Espece FROM Animaux";

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
                    command.CommandText = "SELECT DISTINCT Race FROM Animaux WHERE Espece = @espece";
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
                    command.Parameters.AddWithValue("@codeClient", animal.Client.codeClient);
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

        public static bool DeleteAnimal(Animal animal)
        {
            try
            {
                using (SqlConnection cnx = DALAccess.GetConnection())
                {
                    SqlCommand command = cnx.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "DELETE FROM Animals WHERE Id = @id";
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
    }
}
