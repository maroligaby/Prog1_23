namespace Arquivos.Models
{
    public class Client
    {
        public int Id{ get;set;}        
        public string? FirstName { get; set; }
        public string?LastName {get;set;}
        public string? CPF { get;set;}
        public string? email { get;set;}
        
        public Client()
        {
            
        }
        public Client(int id, 
                    string? firstName, 
                    string? lastName, 
                    string? cPF, 
                    string? email)
        {            
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CPF = cPF;
            this.email = email;
        }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public override string ToString()
        {
            return $"Id: {this.Id}; Name: {this.FullName}; Email: {this.email}";
        }
    }
}
