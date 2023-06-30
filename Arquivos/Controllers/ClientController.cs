using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class ClientController
    {
        private string directoryName = "ReportFiles";
        private string fileName = "Clients.txt";

        public List<Client> List()
        {
            return DataSet.Clients;
        }
        
        public bool Insert(Client client)
        {
            if(client == null)
                return false;

            if (client.Id <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(client.FirstName))
                return false;


            DataSet.Clients.Add(client);
            return true;
        }

        public bool ExportToTextFile()
        {
            if (!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);
            
            string fileContent = string.Empty;
            foreach(Client c in DataSet.Clients)
            {
                fileContent += $"{c.Id};{c.FirstName};{c.LastName};{c.CPF};{c.email}";
                fileContent +="\n";
            }
        
            try
            {
                StreamWriter sw = File.CreateText(
                $"{directoryName}\\{fileName}"
                );

                sw.Write(fileContent);
                sw.Close();
            }
            catch(IOException ioEx)
            {
                Console.WriteLine("Erro ao manipular o arquivo.");
                Console.WriteLine(ioEx.Message);
                return false;
            }

            return true;
        }

        public bool ImportFromTxtFile()
        {
            try
            {
                StreamReader sr = new StreamReader(
                $"{directoryName}\\{fileName}"
                );

                string line = string.Empty;
                line = sr.ReadLine();
                while(line != null)
                {
                    Client client = new Client();
                    string[] clientData = line.Split(';');
                    client.Id = Convert.ToInt32(clientData[0]);
                    client.FirstName = clientData[1];
                    client.LastName = clientData[2];
                    client.CPF = clientData[3];
                    client.email=clientData[4];

                    DataSet.Clients.Add(client);

                    line = sr.ReadLine();
                }

                return true;

            }
            catch(Exception ex)
            {
                Console.WriteLine("Ooops, Ocorreu um erro ao tentar importar os dados");
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public List<Client> SearchByName(string name)
        {
            if (string.IsNullOrEmpty(name) || 
                string.IsNullOrWhiteSpace(name) )
                return null;

            List<Client> clients = new List<Client>();
            for (int i = 0; i<DataSet.Clients.Count; i++)
            {
                var c = DataSet.Clients[i];
                if( c.FullName.ToLower().Contains(name.ToLower()) )
                    clients.Add(c);
            }
            return clients;
        }

        public List<Client> SearchByCPF(string CPF)
        {
            if (string.IsNullOrEmpty(CPF) || 
                string.IsNullOrWhiteSpace(CPF) )
                return null;

            List<Client> clients = new List<Client>();
            for (int i = 0; i<DataSet.Clients.Count; i++)
            {
                var c = DataSet.Clients[i];
                if( c.CPF.ToLower().Contains(CPF.ToLower()) )
                    clients.Add(c);
            }
            return clients;
        }
    
        public int GetNextId()
        {
            int tam = DataSet.Clients.Count;

            Console.WriteLine("Quantidade: " + tam);
         
            if (tam > 0)
                return DataSet.Clients[tam - 1].Id + 1;
            else
                return 1;
        }
    }   
}