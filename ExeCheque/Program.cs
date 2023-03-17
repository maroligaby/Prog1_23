Console.WriteLine ("digite o número que deseja escrever por extenso");
var numeroRecebido = Console.ReadLine();
//Console.WriteLine (numeroRecebido);
string numeroString = Convert.ToString(numeroRecebido);
int qtdchars = numeroString.Length;
Console.WriteLine (qtdchars);

if (qtdchars) == 1
    
    for(int i = 0; i<qtdchars; i++)
    {
        Console.WriteLine(numeroString[i]); 
    }

