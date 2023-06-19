using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class AnimalController
    {
        public List<Animal> List()
        {
            return DataSet.Animals;
        }

        public bool Insert(Animal animal)
        {
            if(animal==null)
                return false;

            if(animal.Id <= 0)
                return false;

            if(string.IsNullOrWhiteSpace(animal.Name))
                return false;

            DataSet.Animals.Add(animal);
            return true;
        }

        public int GetNextId()
        {
            int tam = DataSet.Animals.Count;

            Console.WriteLine("Quantidade: " + tam);
         
            if (tam > 0)
                return DataSet.Animals[tam - 1].Id + 1;
            else
                return 1;
        }


    }
}