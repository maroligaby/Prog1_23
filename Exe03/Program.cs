static void FormatString(
    string stringToFormat)
{
    stringToFormat.Replace("Mundo", "Marte");
}

static string FormatReturningString(string stringToFormat)
{
    return stringToFormat.Replace("Mundo", "Marte");
}

var mensagem = "Olá Mundo!";
//Invocando o método sem retormo
FormatString(mensagem);
Console.WriteLine(mensagem);

var outraMensagem = "Bom dia Mundo!";
Console.WriteLine( FormatReturningString(outraMensagem) );