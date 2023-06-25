using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Vet
    {
        public int Id{ get;set;}        
        public string? FirstName {get;set;}
        public string?LastName {get;set;}
        public string? CPF { get;set;}
        public string? CRMV { get;set;}
        
        public Vet()
        {
            
        }
        public Vet(int id, 
                    string? firstName, 
                    string? lastName, 
                    string? cPF, 
                    string? crmv)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CPF = cPF;
            CRMV = crmv;
        }
    }
}
