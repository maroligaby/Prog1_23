Console.WriteLine("olá, seja bem vindo!");
Console.WriteLine("Qual é o seu nome?");
string name = Console.ReadLine();

Console.WriteLine($"Olá, {name} prazer conhecê-lo.");

//Declarar sem inicializar / primitivo
string message1;
//declarar inicializado / abstrato
String message2 = "Seu nome completo";
//declarar string vazia
string message3 = String.Empty;
string message4 = "";
//declaração com tipo implicito
var message5 = "mensagem aleatória";

message1 = "Rogerio Ceni;pelé;the rock;Roberto Carlos";
var palavras = message1.Split(';');
foreach(var word in palavras)
{
    //variavel de escopo local do laço de repetição foreach
    int a = 10;
    Console.WriteLine(word);
}
