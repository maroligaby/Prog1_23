// Operadores unários
using FluxoTiposExceptions.Classes;

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

Console.WriteLine(quantosBytes);

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

//----------------------------------------------------

Animal[] animals = new Animal[]
{
    new Cat{
        Name = "Garfield", 
        Born = new(year:2022, month:8, day:23),
        Legs = 4,
        IsDomestic = true
    },
    new Animal{
        Name = "eu",
        Born = new(year:2004, month:8, day:19),
        Legs = 2
    },
    null,
    new Cat{
        Name = "Mimi",
        Born = new(year:1994, month:6, day:12),
        Legs = 4,
        IsDomestic = true
    },
    new Spider{
        Name = "Peter Parker",
        Born = DateTime.Today,
        Legs = 8,
        IsPoisonous = true
    },
    new Spider{
        Name = "Eddie Brock",
        Born = DateTime.Today,
        Legs = 8,
        IsPoisonous = true
    }
};

/*laços de repetição
3 tipos de variáveis para controle de repetição
1: Flag - bandeirinha, booleano que indica se para ou continua
2: Counter - contador, conta quantas vezes a repetição ocorreu
3: Acumulador - permite acumular valores a cada repetição
*/

//laço for
Console.WriteLine("\n---FOR---\n");
for(int i = 0; i<animals.Length; i++)
{
    string message =string.Empty;
    if( animals[i]!= null)
    {
        message = $"\nNome: {animals[i].Name} \n";
        message += $"Data: {animals[i].Born.ToShortDateString()} \n";
        message += $"{animals[i].Legs} pernas";
    }
    Console.WriteLine(message);
}


//laço de repetição para cada (foreach)
Console.WriteLine("\n---FOREACH---\n");
foreach(Animal animal in animals)
{
    string message = string.Empty;
    if (animal != null)
    {
        message = $"Nome:{animal.Name} ";
        message+= $"Data:{animal.Born.ToShortDateString()} ";
        message += $"{animal.Legs} pernas";
    }
    Console.WriteLine(message);
    
}