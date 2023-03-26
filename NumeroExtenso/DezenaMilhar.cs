namespace NumeroExtenso
{
    public class DezenaMilhar
    {
        public string DezenaMilharPorExtenso(int numero)
        {

            string retorno ="";
            Unidade unidade = new Unidade();
            Dezena dezena = new Dezena();
            Centena centena = new Centena();
            UnidadeMilhar unidadeMilhar = new UnidadeMilhar();

            if (numero>=10000 && numero <11000) 
               {
                if(numero==10000)
                    return "dez mil";

                if (numero>=10001 && numero<10010)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "dez mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=10010 && numero<=10099)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "dez mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=10100 && numero<=10999)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "dez mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=11000 && numero <12000) 
               {
                if(numero==11000)
                    return "onze mil";

                if (numero>=11001 && numero<11010)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "onze mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=11010 && numero<=11099)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "onze mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=11100 && numero<=11999)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "onze mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=12000 && numero <13000) 
               {
                if(numero==12000)
                    return "doze mil";

                if (numero>=12001 && numero<12010)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "doze mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=12010 && numero<=12099)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "doze mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=12100 && numero<=12999)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "doze mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=13000 && numero <14000) 
               {
                if(numero==13000)
                    return "treze mil";

                if (numero>=13001 && numero<13010)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "treze mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=13010 && numero<=13099)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "treze mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=13100 && numero<=13999)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "treze mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=14000 && numero <15000) 
               {
                if(numero==14000)
                    return "quatorze mil";

                if (numero>=14001 && numero<14010)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "quatorze mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=14010 && numero<=14099)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "quatorze mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=14100 && numero<=14999)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "quatorze mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=15000 && numero <16000) 
               {
                if(numero==15000)
                    return "quinze mil";

                if (numero>=15001 && numero<15010)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "quinze mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=15010 && numero<=15099)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "quinze mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=15100 && numero<=15999)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "quinze mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=16000 && numero <17000) 
               {
                if(numero==16000)
                    return "dezesseis mil";

                if (numero>=16001 && numero<16010)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezesseis mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=16010 && numero<=16099)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezesseis mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=16100 && numero<=16999)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezesseis mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=17000 && numero <18000) 
               {
                if(numero==17000)
                    return "dezessete mil";

                if (numero>=17001 && numero<17010)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezessete mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=17010 && numero<=17099)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezessete mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=17100 && numero<=17999)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezessete mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=18000 && numero <19000) 
               {
                if(numero==18000)
                    return "dezoito mil";

                if (numero>=18001 && numero<18010)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezoito mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=18010 && numero<=18099)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezoito mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=18100 && numero<=18999)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezoito mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=19000 && numero <20000) 
               {
                if(numero==19000)
                    return "dezenove mil";

                if (numero>=19001 && numero<19010)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezenove mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=19010 && numero<=19099)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezenove mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=19100 && numero<=19999)
                {
                    string und = numero.ToString().Substring(2,3);
                    retorno = "dezenove mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=20000 && numero <30000) 
                {
                if(numero==20000)
                    return "vinte mil";

                if (numero>=20001 && numero<20010)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "vinte mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=20010 && numero<=20099)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "vinte mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=20100 && numero<=20999)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "vinte mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=21000 && numero<=30000)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "vinte e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=30000 && numero <40000) 
                {
                if(numero==30000)
                    return "trinta mil";

                if (numero>=30001 && numero<30010)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "trinta mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=30010 && numero<=30099)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "trinta mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=30100 && numero<=30999)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "trinta mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=31000 && numero<=40000)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "trinta e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=40000 && numero <50000) 
                {
                if(numero==40000)
                    return "quarenta mil";

                if (numero>=40001 && numero<40010)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "quarenta mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=40010 && numero<=40099)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "quarenta mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=40100 && numero<=40999)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "quarenta mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=41000 && numero<=50000)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "quarenta e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=50000 && numero <60000) 
                {
                if(numero==50000)
                    return "cinquenta mil";

                if (numero>=50001 && numero<50010)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "cinquenta mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=50010 && numero<=50099)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "cnquenta mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=50100 && numero<=50999)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "cinquenta mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=51000 && numero<=60000)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "ciquenta e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=60000 && numero <70000) 
                {
                if(numero==60000)
                    return "sessenta mil";

                if (numero>=60001 && numero<60010)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "sessenta mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=60010 && numero<=60099)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "sessenta mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=60100 && numero<=60999)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "sessenta mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=61000 && numero<=70000)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "sessenta e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=70000 && numero <80000) 
                {
                if(numero==70000)
                    return "setenta mil";

                if (numero>=70001 && numero<70010)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "setenta mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=70010 && numero<=70099)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "setenta mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=70100 && numero<=70999)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "setenta mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=71000 && numero<=80000)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "setenta e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=80000 && numero <90000) 
                {
                if(numero==80000)
                    return "oitenta mil";

                if (numero>=80001 && numero<80010)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "ointenta mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=80010 && numero<=80099)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "oitenta mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=80100 && numero<=80999)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "oitenta mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=81000 && numero<=90000)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "oitenta e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            if (numero>=90000 && numero <100000) 
                {
                if(numero==90000)
                    return "noventa mil";

                if (numero>=90001 && numero<90010)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "noventa mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=90010 && numero<=90099)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "noventa mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=90100 && numero<=90999)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "noventa mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=91000 && numero<=100000)
                {
                    string und = numero.ToString().Substring(1,4);
                    retorno = "noventa e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
               }
            
            
            else
                return "número inválido";

        }
    }
}