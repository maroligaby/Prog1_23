using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
//inicio do escopo do namespace
{
    //inicio do escopo da classe
    public class Client
    {
        public int Id{ get;set;}        
        public string? FirstName {get;set;}
        public string?LastName {get;set;}
        public string? CPF { get;set;}
        public string? email { get;set;}

        /*os metodos contrutores são responsáveis 
        por instanciar uma variável do tipo 
        especificado pela classe.
        Aregra é de que o construtor tenha o mesmo nome da classe */
        public Client()
        {

        }

        //metedo sempre usa ()
        public Client(int id, 
                    string? firstName, 
                    string? lastName, 
                    string? cPF, 
                    string? email)
        //escopo das definições da classe
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CPF = cPF;
            this.email = email;
        }//fim do escopo da classe


    } //fim do escopo da classe
}//fim do escopo do namespace
