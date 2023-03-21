Console.WriteLine ("digite o número que deseja escrever por extenso");
var numeroRecebido = Console.ReadLine();
//Console.WriteLine (numeroRecebido);
string numeroString = Convert.ToString(numeroRecebido);
var qtdchars = numeroString.Length;
Console.WriteLine (qtdchars);

for(int i = 0; i<qtdchars; i++)
{
    if (qtdchars == 1)
        
        Console.WriteLine(numeroString[i]); 
}

