// Operadores unários
int x = 5;
int incrementoPosFixado = x++; //6
incrementoPosFixado++;
x++; // x = x + 1
int incrementoPrefixado = ++x; //atribuição
Console.WriteLine($"Posfixado: {incrementoPosFixado}");
Console.WriteLine($"Prefixado: {incrementoPrefixado}");

//como obter o tipo de uma variável

Type tipoDeInteiro = typeof(int);
Type tipoDeX = x.GetType();

//como obter o nome de uma variável
string nomeDaVariavel = nameof (x);

//como saber o tamanho de uma variavel
int quantosBytes = sizeof(int);

Console.WriteLine("Nome da var: " + nomeDaVariavel);

//Operadores de atribuição
int p = 6;
p += 3; //equivalente a p = p + 3
Console.WriteLine($"+={p}");

p -= 3; //equivalente a p = p - 3
Console.WriteLine($"+={p}");

p *= 3; //equivalente a p = p * 3
Console.WriteLine($"+={p}");

p /= 3; //equivalente a p = p / 3
Console.WriteLine($"+={p}");

//OPERADORES LÓGICO

bool a = true;
bool b = false;
Console.WriteLine($"AND  | a    | b    ");
Console.WriteLine($"a    |{a & a, -5} | {a & b, -5}");
Console.WriteLine($"b    |{b & a, -5} | {b & b, -5}");

Console.WriteLine();
Console.WriteLine($"OR   | a    | b    ");
Console.WriteLine($"a    |{a | a, -5} | {a | b, -5}");
Console.WriteLine($"b    |{b | a, -5} | {a | b, -5}");
Console.WriteLine();
Console.WriteLine($"XOR  |a    | b     ");
Console.WriteLine($"a    |{a ^ a, -5} | {a ^ b, -5}");
Console.WriteLine($"b    |{b ^ a, -5} | {b ^ b, -5}");

static bool FacaAlgo()
{
    Console.WriteLine("Fazendo alguma coisa");
    return true;
}

Console.WriteLine();
Console.WriteLine($"a & FacaAlgo() = {a & FacaAlgo()}");
Console.WriteLine($"b & FacaAlgo() = {b & FacaAlgo()}");