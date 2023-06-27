using Arquivos.Views;
using Arquivos.Utils;

Bootstrapper.ChargeClients();

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
    }

}
while ( option > 0);