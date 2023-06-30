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

        public override string ToString()
        {
            return $"Id: {this.Id}; Name: {this.Name}; Raça: {this.Raca}; Nascimento: {this.Nascimento};";
        }
    }
}