using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class VetController
    {
        private string directoryName = "ReportFiles";
        private string fileName = "Vets.txt";

        public List<Vet> List()
        {
            return DataSet.Vets;
        }
        
        public bool Insert(Vet vet)
        {
            if(vet == null)
                return false;

            if (vet.Id <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(vet.FirstName))
                return false;


            DataSet.Vets.Add(vet);
            return true;
        }

        public bool ExportToTextFile()
        {
            if (!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);
            
            string fileContent = string.Empty;
            foreach(Vet v in DataSet.Vets)
            {
                fileContent += $"{v.Id};{v.FirstName};{v.LastName};{v.CPF};{v.CRMV}";
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
                    Vet vet = new Vet();
                    string[] vetData = line.Split(';');
                    vet.Id = Convert.ToInt32(vetData[0]);
                    vet.FirstName = vetData[1];
                    vet.LastName = vetData[2];
                    vet.CPF = vetData[3];
                    vet.CRMV = vetData[4];

                    DataSet.Vets.Add(vet);

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
        public List<Vet> SearchByName(string name)
        {
            if (string.IsNullOrEmpty(name) || 
                string.IsNullOrWhiteSpace(name) )
                return null;

            List<Vet> vets = new List<Vet>();
            for (int i = 0; i<DataSet.Vets.Count; i++)
            {
                var v = DataSet.Vets[i];
                if( v.FullName.ToLower().Contains(name.ToLower()) )
                    vets.Add(v);
            }
            return vets;
        }

        public List<Vet> SearchByCRMV(string CRMV)
        {
            if (string.IsNullOrEmpty(CRMV) || 
                string.IsNullOrWhiteSpace(CRMV) )
                return null;

            List<Vet> vets = new List<Vet>();
            for (int i = 0; i<DataSet.Vets.Count; i++)
            {
                var v = DataSet.Vets[i];
                if( v.CRMV.ToLower().Contains(CRMV.ToLower()) )
                    vets.Add(v);
            }
            return vets;
        }
        public int GetNextId()
        {
            int tam = DataSet.Vets.Count;

            Console.WriteLine("Quantidade: " + tam);
         
            if (tam > 0)
                return DataSet.Vets[tam - 1].Id + 1;
            else
                return 1;
        }
    }   
}