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

        // Update
        public static bool UpdateAnimal(Animal pAnimal)
        {
            return DALAnimal.SetAnimal(pAnimal);
        }

        public static bool UpdateTatouage(String tatouage, Guid codeAnimal)
        {
            return DALAnimal.SetTatouage(tatouage, codeAnimal);
        }

        // Delete
        public static bool DeleteAnimal(Guid id)
        {
            return DALAnimal.DeleteAnimal(id);
        }

        public static bool DeleteAnimalByClient(Client pClient)
        {
            return DALAnimal.DeleteAnimalByClient(pClient);
        }

        #endregion
    }
}
