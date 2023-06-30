using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Utils
{
    public static class Bootstrapper
    {
        public static void ChargeClients()
        {
            DataSet.Clients.Add(
                new Client{
                    Id = 1,
                    FirstName = "Fernando",
                    LastName = "Becker",
                    CPF = "045.465.465-09",
                    email = "f.becker@unoesc.edu.br"
                } 
            );   
        }
       
        public static void ChargeAnimals()
        {
            DataSet.Animals.Add(
                new Animal{
                    Id = 1,
                    Name = "Molly",
                    Raca = "pitbull",
                    Nascimento = "12-12-2019"
                } 
            );   
        }

        public static void ChargeVets()
        {
            DataSet.Vets.Add(
                new Vet{
                    Id = 1,
                    FirstName = "Nicoli",
                    LastName = "Bulgarelli",
                    CPF = "567.098.123-45",
	                CRMV = "694218"
                } 
            );   
        }

        public static void ChargeClinicas()
        {
            DataSet.Clinicas.Add(
                new Clinica{
                    Id = 1,
                    Name = "Cuidado Animal",
                    CNPJ = "09.567.123/0001-32",
                    Telefone = "(49) 9 9845-1237",
	        Endereco = "Rua x, São Paulo - SP, Brasil"
                } 
            );   
        }
    }
}