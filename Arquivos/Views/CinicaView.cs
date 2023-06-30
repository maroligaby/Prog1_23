using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class ClinicaView
    {
        private ClinicaController clinicaController;

        public ClinicaView()
        {
            clinicaController = new ClinicaController();
            this.Init();
        }   
        public void Init()
        {
            Console.WriteLine("***************");
            Console.WriteLine("CLINICAS");
            Console.WriteLine("***************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir clinica");
            Console.WriteLine("2 - listar clinicas");
            Console.WriteLine("3 - Exportar para txt");
            Console.WriteLine("4 - Importar clinicas");
            Console.WriteLine("5 - Pesquisar clinicas");
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
                    Console.WriteLine("1 - Pesquisar clínica por nome.");
                    Console.WriteLine("2 - Pesquisar Clínica por endereço.");
                    int tipoPesquisa = Convert.ToInt32(Console.ReadLine() );
                    if(tipoPesquisa ==1)
                        SearchByName();
                    if(tipoPesquisa == 2)
                        SearchByEndereco();
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
            List<Clinica> listagem = 
                clinicaController.List();

            for (int i=0; i <listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }
        }

        private string Print(Clinica clinica)
        {
            string retorno = "";
            retorno+= $"Id: {clinica.Id} \n";
            retorno+= $"Nome: {clinica.Name}\n";
	        retorno +=$"Endereço: {clinica.Endereco}\n";
	        retorno +=$"Telefone: {clinica.Telefone}\n";
            retorno +=$"CNPJ: {clinica.CNPJ}\n";
            retorno+= "-------------------------------------------\n";
            return retorno;
        }
        private void Insert()
        {
            Clinica clinica = new Clinica();
            clinica.Id = clinicaController.GetNextId();
            
            Console.WriteLine("Informe nome da clínica:");
            clinica.Name = Console.ReadLine();
            
            Console.WriteLine("Informe o CNPJ da clínica:");
            clinica.CNPJ = Console.ReadLine();
            
            Console.WriteLine("Informe o telefone:");
            clinica.Telefone = Console.ReadLine();

            Console.WriteLine("Informe o endereço:");
            clinica.Endereco = Console.ReadLine();

            bool retorno = clinicaController.Insert(clinica);

            if (retorno)
                Console.WriteLine("Clinica inserida com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }
        private void Export()
        {
            if(clinicaController.ExportToTextFile())
                Console.WriteLine("Arquivo gerado com sucesso!");

            else
                Console.WriteLine("Ooops! Ocorreu uma falha na geração do arquivo.");
            
        }

        private void Import()
        {
            if(clinicaController.ImportFromTxtFile())
                Console.WriteLine("Arquivo importado com sucesso!");
            else
                Console.WriteLine("Ooops! Ocorreu uma falha na importação do arquivo.");
        }

        private void SearchByName()
        {
            Console.WriteLine ("Pesquisar clinica pelo nome.");
            Console.WriteLine ("Digite aqui o nome: ");
            string name = Console.ReadLine();

            int contador = 0;
            foreach( Clinica c in clinicaController.SearchByName(name))
            {
                Console.WriteLine(c.ToString());
                contador++;
            }
            if(contador == 0)
                Console.WriteLine("\nDado não encontrado!\n"); 
        }
         private void SearchByEndereco()
        {
            Console.WriteLine ("Digite o Endereço da clínica aqui.");
            string Endereco = Console.ReadLine();

            int contador = 0;
            foreach( Clinica c in clinicaController.SearchByEndereco(Endereco))
            {
                Console.WriteLine(c.ToString());
                contador ++;
            }
            if(contador == 0)
                Console.WriteLine("\nDado não encontrado!\n");        
        }

    }
}