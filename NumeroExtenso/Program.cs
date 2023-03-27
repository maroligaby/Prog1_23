
using NumeroExtenso;

Console.WriteLine ("***************************");
Console.WriteLine ("Escrever número por extenso");
Console.WriteLine ("***************************");

Console.WriteLine("Informe um número inteiro");
string numero = Console.ReadLine();
int nro;
try
{
    nro = Convert.ToInt32(numero);
}
catch
{
    Console.WriteLine ("O número não é válido");
    return;
}
string retorno = "";
switch(numero.Length)
{
    case 1: 
        Unidade unidade = new Unidade();
        retorno = unidade.UnidadePorExtenso(nro);
    break;
    case 2:
        Dezena dezena = new Dezena();
        retorno = dezena.DezenaPorExtenso(nro);
    break;
    case 3:
        Centena centena = new Centena();
        retorno = centena.CentenaPorExtenso(nro);
    break;
    case 4:
        UnidadeMilhar unidadeMilhar = new UnidadeMilhar();
        retorno = unidadeMilhar.UnidadeMilharPorExtenso(nro);
    break;
    case 5:
        DezenaMilhar dezenaMilhar = new DezenaMilhar();
        retorno = dezenaMilhar.DezenaMilharPorExtenso(nro);
    break;
    case 6:
        CentenaMilhar centenaMilhar = new CentenaMilhar();
        retorno = centenaMilhar.CentenaMilharPorExtenso(nro);
    break;
    
};
Console.WriteLine(retorno);
