
string password = "samurai";
string retorno = string.Empty;

if (password.Length < 10)
{
    retorno = @"Sua senha é muito curta.
                Use ao menos 10 caraceres";
    retorno += " seu jaguara";
}
else if (password.Length>=15)
    retorno = @"Sua senha é muito longa.
                Use entre 10 e 15 caracteres";

else
    retorno="Sua senha está de acordo.";

Console.WriteLine(retorno);

//checagem de valor e tipo
/*
    Em java script podemos fazer assim:
    var a = "1";
    let b = 1;
    (a==b) retornará True #comparação de conteúdo#
    (a===b) retornará False #comparação de tipos#
*/

object o = 3;
int j = 4;
if(o is int i)
{
    Console.WriteLine($"{i} x {j} = {i*j}");
}
else
{
    Console.WriteLine(@"o não é um inteiro,
                    portanto não é possível multiplicar");
}

//comando switch
int number = Random.Shared.Next(1,7);
Console.WriteLine($"meu número aleatório é {number}");
switch(number)
{
    case 1:
        Console.WriteLine("um");
    break;
    case 2:
        Console.WriteLine("dois");
    break;
    case 3:
    case 4:
        Console.WriteLine("três ou quatro");
    goto case 1;
    case 5:
        goto A_label;
    default:
        Console.WriteLine("default");
        break;

}
Console.WriteLine("depois do fim do switch");
A_label:
Console.WriteLine("depois de A_label");
//função == método, porém método é void e função há retorno