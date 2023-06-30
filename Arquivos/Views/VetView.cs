using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class VetView
    {
        private VetController vetController;

        public VetView()
        {
            vetController = new VetController();
            this.Init();
        }   
        public void Init()
        {
            Console.WriteLine("***************");
            Console.WriteLine("VETERINÁRIOS");
            Console.WriteLine("***************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir veterinário");
            Console.WriteLine("2 - listar veterinários");
            Console.WriteLine("3 - Exportar para txt");
            Console.WriteLine("4 - Importar veterinários");
            Console.WriteLine("5 - Pesquisar veterinários");
            Console.WriteLine("0 - Voltar");
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
                case 3:
                    Export();
                break;
                case 4:
                    Import();
                break;
                case 5:
                    Console.WriteLine("PESQUISA");
                    Console.WriteLine("***************");
                    Console.WriteLine("1 - Pesquisar veterinário por nome.");
                    Console.WriteLine("2 - Pesquisar veterinário por CRMV.");
                    int tipoPesquisa = Convert.ToInt32(Console.ReadLine() );
                    if(tipoPesquisa == 1)
                        SearchByName();
                    if(tipoPesquisa == 2)
                        SearchByCRMV();
                    if(tipoPesquisa != 1 && tipoPesquisa !=2)
                        Console.WriteLine("\nOpção inválida.\n");
                break;

                case 0:
                break;

                default:
                    Console.WriteLine("OOps, opção inválida!");
                    this.Init();
                break;
            }
        }

        private void List()
        {
            List<Vet> listagem = 
                vetController.List();

            for (int i=0; i <listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }
        }

        private string Print(Vet vet)
        {
            string retorno = "";
            retorno+= $"Id: {vet.Id} \n";
            retorno+= $"Nome: {vet.FullName}\n";
            retorno+= $"CPF: {vet.CPF}\n";
            retorno+= $"CRMV: {vet.CRMV}\n";
            retorno+= "-------------------------------------------\n";
            return retorno;
        }
        private void Insert()
        {
            Vet vet = new Vet();
            vet.Id = vetController.GetNextId();
            
            Console.WriteLine("Informe o primeiro nome:");
            vet.FirstName = Console.ReadLine();
            
            Console.WriteLine("Informe o sobrenome:");
            vet.LastName = Console.ReadLine();
            
            Console.WriteLine("Informe o CRMV:");
            vet.CRMV = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            vet.CPF = Console.ReadLine();

            bool retorno = vetController.Insert(vet);

            if (retorno)
                Console.WriteLine("Veterinário inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }
        private void Export()
        {
            if(vetController.ExportToTextFile())
                Console.WriteLine("Arquivo gerado com sucesso!");

            else
                Console.WriteLine("Ooops! Ocorreu uma falha na geração do arquivo.");
            
        }

        private void Import()
        {
            if(vetController.ImportFromTxtFile())
                Console.WriteLine("Arquivo importado com sucesso!");
            else
                Console.WriteLine("Ooops! Ocorreu uma falha na importação do arquivo.");
        }

         private void SearchByName()
        {
            Console.WriteLine ("Digite o nome do veterinário aqui.");
            string name = Console.ReadLine();

            int contador = 0;
            foreach( Vet v in vetController.SearchByName(name))
            {
                Console.WriteLine(v.ToString());
                contador ++;
            }
            if(contador == 0)
                Console.WriteLine("\nDado não encontrado!\n");        
        }
        private void SearchByCRMV()
        {
            Console.WriteLine ("Digite o CRMV do veterinário aqui.");
            string CRMV = Console.ReadLine();

            int contador = 0;
            foreach( Vet v in vetController.SearchByCRMV(CRMV))
            {
                Console.WriteLine(v.ToString());
                contador ++;
            }
            if(contador == 0)
                Console.WriteLine("\nDado não encontrado!\n");        
        }
    }
}