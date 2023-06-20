using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class AnimalView
    {
        private AnimalController animalController;

        public AnimalView()
        {
            animalController = new AnimalController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("***************");
            Console.WriteLine("VOCÊ ESTÁ EM ANIMAIS");
            Console.WriteLine("***********");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir animal");
            Console.WriteLine("2 - listar animais");
            Console.WriteLine("3 - Exportar animais para txt");
            Console.WriteLine("4 - Importar animais");
            Console.WriteLine("***************");
            Console.WriteLine("");

            int option = 0;
            option = Convert.ToInt32(Console.ReadLine() );
            switch(option){
                case 1 :
                    Insert();
                break;

                case 2 :
                    List();
                break;

                case 3 :
                    Export();
                break;

                case 4 :
                    Import();
                break;

                default:
                break;
            }
        }

        private void List()
        {
            List<Animal> listagem = animalController.List();

            for (int i=0; i<listagem.Count; i++)
            {
                Console.WriteLine (Print(listagem[i]));
            }
        }

        private string Print (Animal animal)
        {
            string retorno = "";
            retorno += $"Id: {animal.Id} \n";
            retorno+= $"Nome: {animal.Name} \n";
            retorno+=$"Raça: {animal.Raca} \n";
            retorno+= "-------------------------------------------\n";
            return retorno;
        }

        private void Insert()
        {
            Animal animal = new Animal();
            animal.Id = animalController.GetNextId();

            Console.WriteLine("Informe o nome do animal:");
            animal.Name = Console.ReadLine();

            Console.WriteLine("Informe a raça:");
            animal.Raca = Console.ReadLine();

            Console.WriteLine("Informe o Nascimento do animal:");
            animal.Nascimento = Console.ReadLine();

            bool retorno = animalController.Insert(animal);

            if (retorno)
                Console.WriteLine("Animal inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }

        private void Export()
        {
            if (animalController.ExportToTextFile())
                Console.WriteLine("Arquivo gerado com suceso!");
            
            else
                Console.WriteLine("Ooops! Ocorreu uma falha na geração do arquivo.");
        }
        private void Import()
        {
            if (animalController.ImportFromTxtFile())
                Console.WriteLine("Arquivo importado com suceso!");
            
            else
                Console.WriteLine("Ooops! Ocorreu uma falha na importação do arquivo.");
        }
    }
}