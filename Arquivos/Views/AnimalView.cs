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
            Console.WriteLine("*****************");
            Console.WriteLine("ANIMAIS");
            Console.WriteLine("*****************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir animal");
            Console.WriteLine("2 - listar animais");
            Console.WriteLine("3 - Exportar para txt");
            Console.WriteLine("4 - Importar animais");
            Console.WriteLine("5 - Pesquisar animais");
            Console.WriteLine("0 - Voltar");
            Console.WriteLine("*****************");
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
                case 3:
                    Export();
                break;
                case 4:
                    Import();
                break;
                case 5:
                    Console.WriteLine("PESQUISA");
                    Console.WriteLine("***************");
                    Console.WriteLine("1 - Pesquisar animal por nome.");
                    Console.WriteLine("2 - Pesquisar animal por Data de Nascimento.");
                    int tipoPesquisa = Convert.ToInt32(Console.ReadLine() );
                    if(tipoPesquisa ==1)
                        SearchByName();
                    if(tipoPesquisa == 2)
                        SearchByNascimento();
                    if(tipoPesquisa != 1 && tipoPesquisa !=2)
                        Console.WriteLine("\nOpção inválida.\n");
                break;
                case 0:
                break;

                default:
                    Console.WriteLine("\nOOps, opção inválida!\n");
                    this.Init();
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
            retorno+= $"Id: {animal.Id} \n";
            retorno+= $"Nome: {animal.Name} \n";
            retorno+= $"Raça: {animal.Raca} \n";
            retorno+= $"Nascimento: {animal.Nascimento}\n";
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

        private void SearchByName()
        {
            Console.WriteLine ("Pesquisar animal pelo nome.");
            Console.WriteLine ("Digite aqui o nome: ");
            string name = Console.ReadLine();

            int contador = 0;
            foreach( Animal a in animalController.SearchByName(name))
            {
                Console.WriteLine(a.ToString());
                contador ++;
            }
            if(contador == 0)
                Console.WriteLine("\nDado não encontrado!\n");  
        }
        private void SearchByNascimento()
        {
            Console.WriteLine ("Digite a data de Nacimento do animal aqui.");
            string Nascimento = Console.ReadLine();

            int contador = 0;
            foreach( Animal a in animalController.SearchByNascimento(Nascimento))
            {
                Console.WriteLine(a.ToString());
                contador ++;
            }
            if(contador == 0)
                Console.WriteLine("\nDado não encontrado!\n");        
        }
    }
}