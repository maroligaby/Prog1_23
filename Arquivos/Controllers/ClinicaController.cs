using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class ClinicaController
    {
        private string directoryName = "ReportFiles";
        private string fileName = "Clinicas.txt";

        public List<Clinica> List()
        {
            return DataSet.Clinicas;
        }
        
        public bool Insert(Clinica clinica)
        {
            if(clinica == null)
                return false;

            if (clinica.Id <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(clinica.Name))
                return false;


            DataSet.Clinicas.Add(clinica);
            return true;
        }

        public bool ExportToTextFile()
        {
            if (!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);
            
            string fileContent = string.Empty;
            foreach(Clinica c in DataSet.Clinicas)
            {
                fileContent += $"{c.Id};{c.Name};{c.CNPJ};{c.Endereco};{c.Telefone}";
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
                    Clinica clinica = new Clinica();
                    string[] clinicaData = line.Split(';');
                    clinica.Id = Convert.ToInt32(clinicaData[0]);
                    clinica.Name = clinicaData[1];
                    clinica.CNPJ = clinicaData[2];
                    clinica.Endereco = clinicaData[3];
                    clinica.Telefone = clinicaData[4];

                    DataSet.Clinicas.Add(clinica);

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

        public List<Clinica> SearchByName(string name)
        {
            if (string.IsNullOrEmpty(name) || 
                string.IsNullOrWhiteSpace(name) )
                return null;

            List<Clinica> clinicas = new List<Clinica>();
            for (int i = 0; i<DataSet.Clinicas.Count; i++)
            {
                var c = DataSet.Clinicas[i];
                if( c.Name.ToLower().Contains(name.ToLower()) )
                    clinicas.Add(c);
            }
            return clinicas;
        }

        public List<Clinica> SearchByEndereco(string Endereco)
        {
            if (string.IsNullOrEmpty(Endereco) || 
                string.IsNullOrWhiteSpace(Endereco) )
                return null;

            List<Clinica> clinicas = new List<Clinica>();
            for (int i = 0; i<DataSet.Clinicas.Count; i++)
            {
                var c = DataSet.Clinicas[i];
                if( c.Endereco.ToLower().Contains(Endereco.ToLower()) )
                    clinicas.Add(c);
            }
            return clinicas;
        }
    
        public int GetNextId()
        {
            int tam = DataSet.Clinicas.Count;

            Console.WriteLine("Quantidade: " + tam);
         
            if (tam > 0)
                return DataSet.Clinicas[tam - 1].Id + 1;
            else
                return 1;
        }
    }   
}