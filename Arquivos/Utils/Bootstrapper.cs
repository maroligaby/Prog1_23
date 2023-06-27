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
            var c1 = new Client{
                Id = 1,
                FirstName = "gabrielly",
                LastName = "Maroli",
                CPF = "045.465.465-46",
                email = "gabymaroli@hotmail.com"
            };
            DataSet.Clients.Add(c1);

            DataSet.Clients.Add(
                new Client{
                    Id = 2,
                    FirstName = "Eduardo",
                    LastName = "Blank",
                    CPF = "045.465.465-09",
                    email = "eduardoblank@unoesc.edu.br"
                } 
            );      

            DataSet.Clients.Add(
                new Client{
                    Id = 3,
                    FirstName = "Aguinaldo",
                    LastName = "Timóteo",
                    CPF = "045.465.465-10",
                    email = "aguinaldotimoteo@unoesc.edu.br"
                }       
            );

        }
    }
}