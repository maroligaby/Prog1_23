var myFloat = 10f;
float meuFloat = 11;

//conversão de tipo numérico 
int myInteger = 100;
meuFloat = (float)myInteger;
decimal myDecimal = Convert.ToDecimal(myInteger);

var myDouble = 10d;
myDecimal =10m;

string meuNumeroTexto = Convert.ToString(myInteger);
int qtdchars = meuNumeroTexto.Length;
for(int i = 0; i<qtdchars; i++)
//parametros do laço de repetição:
//i<qtdchars = flag
//i=0 = contador
//i++ = acumulador
{
    Console.WriteLine(meuNumeroTexto[i]);
}
