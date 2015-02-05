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
        public static bool CreateAnimal(Animal pAnimal, Client pClient)
        {
            return DALAnimal.AddAnimal(pAnimal, pClient);
        }

        // Read
        public static Animal GetAnimal(Guid id)
        {
            return DALAnimal.GetAnimal(id);
        }

        public static List<Animal> GetAnimalsByClient(Guid id)
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
        public static bool DeleteAnimal(Guid id)
        {
            return DALAnimal.DeleteAnimal(id);
        }

        #endregion
    }
}
