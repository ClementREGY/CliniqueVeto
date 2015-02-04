using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class MgtAnimal
    {
        #region Méthodes CRUD

        // Create
        public static bool CreateAnimal(Animal pAnimal)
        {
            return DALAnimal.AddAnimal(pAnimal);
        }

        // Read
        public static Animal GetAnimal(int id)
        {
            return DALAnimal.GetAnimal(id);
        }

        public static List<Animal> GetAnimalsByClient(int id)
        {
            return DALAnimal.GetAnimalsByClient(id);
        }

        public static List<Animal> GetAnimals()
        {
            return DALAnimal.GetAnimals();
        }

        public static List<String> GetEspeces()
        {
            return DALAnimal.GetEspeces();
        }

        public static List<String> GetRaces(String espece)
        {
            return DALAnimal.GetRaces(espece);
        }

        // Update
        public static bool UpdateAnimal(Animal pAnimal)
        {
            return DALAnimal.SetAnimal(pAnimal);
        }

        // Delete
        public static bool DeleteAnimal(Animal pAnimal)
        {
            return DALAnimal.DeleteAnimal(pAnimal);
        }

        #endregion
    }
}
