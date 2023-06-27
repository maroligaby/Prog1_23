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
            Console.WriteLine("VOCÊ ESTÁ EM VETERINÁRIOS");
            Console.WriteLine("***********");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir veterinário");
            Console.WriteLine("2 - listar veterinários");
            Console.WriteLine("3 - Exportar para txt");
            Console.WriteLine("4 - Importar veterinários");
            Console.WriteLine("5 - Pesquisar veterinários");
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
                    SearchByName();
                break;

                default:
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
            retorno+= $"Nome: {vet.FirstName} {vet.LastName}\n";
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
            
            Console.WriteLine("Informe o CRMV_CE:");
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
            Console.WriteLine ("Pesquisar veterinário pelo nome.");
            Console.WriteLine ("Digite aqui o nome: ");
            string name = Console.ReadLine();

            foreach( Vet v in vetController.SearchByName(name))
            {
                Console.WriteLine(v.ToString());
            }
        }


    }
}