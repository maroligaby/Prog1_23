using Arquivos.Views;
using Arquivos.Utils;

Bootstrapper.ChargeClients();
Bootstrapper.ChargeAnimals();
Bootstrapper.ChargeVets();
Bootstrapper.ChargeClinicas();

int option = 0;

do
{

    Console.WriteLine ("*******************************************");
    Console.WriteLine ("Programa para leitura e exportação de dados");
    Console.WriteLine ("*******************************************");
    Console.WriteLine("");
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Animais");
    Console.WriteLine("3 - Veterinários");
    Console.WriteLine("4 - Clínicas");
    Console.WriteLine("0 - Sair do programa");

    option = Convert.ToInt32 ( Console.ReadLine () );

    switch ( option)
    {
        case 1 :
            Console.WriteLine ("OPÇÃO CLIENTES");
             ClientView clientView = new ClientView();
        break;

        case 2 :
            Console.WriteLine ("OPÇÃO ANIMAIS");
            AnimalView animalView = new AnimalView();
        break;

        case 3 :
            Console.WriteLine ("OPÇÃO VETERINÁRIOS");
            VetView vetView = new VetView();
        break;

        case 4 :
            Console.WriteLine ("OPÇÃO CLÍNICAS");
            ClinicaView clinicaView = new ClinicaView();
        break;
        case 0 :
        break;

        default:
            Console.WriteLine("OOps, opção inválida!");
        break;
    }

}
while ( option > 0);