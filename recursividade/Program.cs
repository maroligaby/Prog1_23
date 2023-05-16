using System;

Console.WriteLine("Cálculo Tabuada Recursivo");
Console.WriteLine("**************************");
Console.WriteLine();

Console.WriteLine("Digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Fatorial de {numero} é {Factorial(numero)}");
//Console.WriteLine($"Fibonacci de {numero} é {Fibonacci(numero)}");
//Console.WriteLine($"Tabuada de {numero} é {MultiplicarFor}");
Console.WriteLine($"Tabuada de {numero} é {MultiplicarRecursivo}");

static int Factorial(int number)
{
    //Caso base 1
    if (number < 0)
    {
        throw new ArgumentException(
            message: $"A função fatorial não suporta números negativos. Input {number}",
            paramName: nameof(number)
        );
    }
    //Caso base 2
    else if(number==0)
    {
        return 1;
    }
    //Caso recursivo
    else
    {
        return number * Factorial(number - 1);
    }
}

static long Fibonacci(int n)
{
    if(n <= 2L) //caso base
        return 1L;
    //caso recursivo
    return Fibonacci(n-1) + Fibonacci (n-2);
}

static void MultiplicarWhile(int n)
{
    int fator = 1;
    while(fator <= 10)
    {
        Console.WriteLine($"{n} x {fator}");
        fator ++;
    }
}

static void MultiplicarFor(int n)
{
    for(int i = 1; 1<=10; i++)
    {
        Console.WriteLine($"{n} x {i} = {n*i}");
    }
}

static void MultiplicarRecursivo(int n) {
    ImprimirTabuada(n, 1);
}
static void ImprimirTabuada(int n, int fator) {
        if (fator <= 10) { // caso base
            Console.WriteLine($"{n} X {fator} = {n * fator}");
            ImprimirTabuada(n, fator + 1);
        }
    }
