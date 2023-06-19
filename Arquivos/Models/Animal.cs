namespace Arquivos.Models
{
    public class Animal
    {
        public int Id {get;set;}
        public string? Name {get;set;}
        public string? Raca {get;set;}
        public string? Nascimento {get;set;}

        public Animal()
        {

        }

        public Animal (int id,string? name, string? raca, string? nascimento)
        {
            id = Id;
            name = Name;
            raca = Raca;
            nascimento = Nascimento;
        }
    }
}