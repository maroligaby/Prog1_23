using Atividade_01.Classes;

Pessoa[] pessoas = new Pessoa[]
{
    new Gerente {
        Name ="Mario",
        Nascimento = new(year:1996, month:5,day:31),
        CodigoFuncionario = 166,
        NumeroFilial = 3,
        Homeoffice = false,
        TemLideranca = true
    },
    new Supervisor{
        Name = "Leila",
        Nascimento = new(year:2000, month:9, day:19),
        CodigoFuncionario = 243,
        Setor = "contabilidade",
        AcessaCameras = true,
        Atento = true
    },
    new Operario{
        Name= "Nicolas",
        Nascimento = new(year:1975, month:4, day:08),
        CodigoFuncionario = 341,
        Funcao = "motorista",
        contratacao = DateTime.Today,
        dirige = true
    },
    new Operario{
        Name = "Giovana",
        Nascimento = new(year:2001, month:02,day:15),
        CodigoFuncionario = 367,
        Funcao = "secretária",
        contratacao = DateTime.Today,
        dirige = false
    },
    new Supervisor{
        Name = "Marina",
        Nascimento= new(year:1982,month:7,day:16),
        CodigoFuncionario = 444,
        Setor = "Financeiro",
        AcessaCameras = false,
        Atento = true,
        contratacao = DateTime.Today
    }

};

for (int i = 0; i<pessoas.Length; i++)
{
    string message = string.Empty;
    if (pessoas[i] != null)
    {
        message= $"\nNome: {pessoas[i].Name}";
        message +=$"\nNascimento: {pessoas[i].Nascimento.ToShortDateString()}";
        message +=$"\nCódigo do funcionário: {pessoas[i].CodigoFuncionario}";
        message +=$"\nContratado desde: {pessoas[i].contratacao.ToShortDateString()}";
    }
    
    Console.WriteLine(message);
}