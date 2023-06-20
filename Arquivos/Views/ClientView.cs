using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class ClientView
    {
        private ClientController clientController;

        public ClientView()
        {
            clientController = new ClientController();
            this.Init();
        }   
        public void Init()
        {
            Console.WriteLine("***************");
            Console.WriteLine("VOCÊ ESTÁ EM CLIENTES");
            Console.WriteLine("***********");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir cliente");
            Console.WriteLine("2 - listar clientes");
            Console.WriteLine("3 - Exportar para txt");
            Console.WriteLine("4- Importar clientes");
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

                default:
                break;
            }
        }

        private void List()
        {
            List<Client> listagem = 
                clientController.List();

            for (int i=0; i <listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }
        }

        private string Print(Client client)
        {
            string retorno = "";
            retorno+= $"Id: {client.Id} \n";
            retorno+= $"Nome: {client.FirstName} {client.LastName}\n";
            retorno+= "-------------------------------------------\n";
            return retorno;
        }
        private void Insert()
        {
            Client client = new Client();
            client.Id = clientController.GetNextId();
            
            Console.WriteLine("Informe o primeiro nome:");
            client.FirstName = Console.ReadLine();
            
            Console.WriteLine("Informe o sobrenome:");
            client.LastName = Console.ReadLine();
            
            Console.WriteLine("Informe o email:");
            client.email = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            client.CPF = Console.ReadLine();

            bool retorno = clientController.Insert(client);

            if (retorno)
                Console.WriteLine("Cliente inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }
        private void Export()
        {
            if(clientController.ExportToTextFile())
                Console.WriteLine("Arquivo gerado com sucesso!");

            else
                Console.WriteLine("Ooops! Ocorreu uma falha na geração do arquivo.");
            
        }

        private void Import()
        {
            if(clientController.ImportFromTxtFile())
                Console.WriteLine("Arquivo importado com sucesso!");
            else
                Console.WriteLine("Ooops! Ocorreu uma falha na importação do arquivo.");
        }

    }
}