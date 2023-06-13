/*
Programa para leitura de dados de pessoas
e exportação de arquivos .txt
*/
using Arquivos.Views;

int option = 0;

do
{

    Console.WriteLine ("*******************************************");
    Console.WriteLine ("Programa para leitura e exportação de dados");
    Console.WriteLine ("*******************************************");
    Console.WriteLine("");
    Console.WriteLine("1 - Clientes");
     Console.WriteLine("2 - Animais");

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
    }

}
while ( option > 0);