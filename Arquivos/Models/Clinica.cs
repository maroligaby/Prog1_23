using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Clinica
    {
        public int Id{ get;set;}        
        public string? Name {get;set;}
        public string? Endereco {get;set;}
        public string? CNPJ { get;set;}
        public string? Telefone { get;set;}
        
        public Clinica()
        {
            
        }

        public override string ToString()
        {
            return $"Id: {this.Id}; Name: {this.Name}; Endereço: {this.Endereco}; CNPJ:{this.CNPJ}; Telefone: {this.Telefone}";
        }

    }
}