namespace NumeroExtenso
{
    public class CentenaMilhar
    {
        public string CentenaMilharPorExtenso(int numero)
        {

            string retorno = "";
            Unidade unidade = new Unidade();
            Dezena dezena = new Dezena();
            Centena centena = new Centena();
            UnidadeMilhar unidadeMilhar = new UnidadeMilhar();
            DezenaMilhar dezenaMilhar = new DezenaMilhar();

            if (numero >= 100000 && numero<200000)
            {
                if (numero == 100000)
                    return "cem mil";
                if (numero>=100001 && numero <100010)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "cem mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if (numero>=100010 && numero <100100)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "cem mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=100100 && numero <101000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "cem mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=101000 && numero <110000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "cento e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                }
                if(numero >=110000 && numero<200000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "cento e ";
                    retorno += dezenaMilhar.DezenaMilharPorExtenso(Convert.ToInt32(und));
                }
                return retorno;
            }  
            if (numero >= 200000 && numero<300000)
            {
                if (numero == 200000)
                    return "duzentos mil";
                if (numero>=200001 && numero <200010)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "duzentos mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if (numero>=200010 && numero <200100)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "duzentos mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=200100 && numero <201000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "duzentos mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=201000 && numero <210000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "duzentos e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                }
                if(numero >=210000 && numero<300000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "duzentos e ";
                    retorno += dezenaMilhar.DezenaMilharPorExtenso(Convert.ToInt32(und));
                }
                return retorno;
            }  
            if (numero >= 300000 && numero<400000)
            {
                if (numero == 300000)
                    return "trezentos mil";
                if (numero>=300001 && numero <300010)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "trezentos mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if (numero>=300010 && numero <300100)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "trezentos mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=300100 && numero <301000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "trezentos mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=301000 && numero <310000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "trezentos e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                }
                if(numero >=310000 && numero<400000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "trezentos e ";
                    retorno += dezenaMilhar.DezenaMilharPorExtenso(Convert.ToInt32(und));
                }
                return retorno;
            }  
            if (numero >= 400000 && numero<500000)
            {
                if (numero == 400000)
                    return "quatrocentos mil";
                if (numero>=400001 && numero <400010)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "quatrocentos mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if (numero>=400010 && numero <400100)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "quatrocentos mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=400100 && numero <401000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "quatrocentos mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=401000 && numero <410000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "quatrocentos e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                }
                if(numero >=410000 && numero<500000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "quatrocentos e ";
                    retorno += dezenaMilhar.DezenaMilharPorExtenso(Convert.ToInt32(und));
                }
                return retorno;
            }  
            if (numero >= 500000 && numero<600000)
            {
                if (numero == 500000)
                    return "quinhentos mil";
                if (numero>=500001 && numero <500010)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "quinhentos mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if (numero>=500010 && numero <500100)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "quinhentos mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=500100 && numero <501000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "quinhentos mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=501000 && numero <510000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "quinhentos e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                }
                if(numero >=510000 && numero<600000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "quinhentos e ";
                    retorno += dezenaMilhar.DezenaMilharPorExtenso(Convert.ToInt32(und));
                }
                return retorno;
            }  
            if (numero >= 600000 && numero<700000)
            {
                if (numero == 600000)
                    return "seiscentos mil";
                if (numero>=600001 && numero <600010)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "seiscentos mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if (numero>=600010 && numero <600100)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "seiscentos mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=600100 && numero <601000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "seiscentos mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=601000 && numero <610000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "seiscentos e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                }
                if(numero >=610000 && numero<700000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "seiscentos e ";
                    retorno += dezenaMilhar.DezenaMilharPorExtenso(Convert.ToInt32(und));
                }
                return retorno;
            }  
            if (numero >= 700000 && numero<800000)
            {
                if (numero == 700000)
                    return "setecentos mil";
                if (numero>=700001 && numero <700010)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "setecentos mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if (numero>=700010 && numero <700100)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "setecentos mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=700100 && numero <701000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "setecentos mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=701000 && numero <710000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "setecentos e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                }
                if(numero >=710000 && numero<800000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "setecentos e ";
                    retorno += dezenaMilhar.DezenaMilharPorExtenso(Convert.ToInt32(und));
                }
                return retorno;
            }  
            if (numero >= 800000 && numero<900000)
            {
                if (numero == 800000)
                    return "oitocentos mil";
                if (numero>=800001 && numero <800010)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "oitocentos mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if (numero>=800010 && numero <800100)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "oitocentos mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=800100 && numero <801000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "oitocentos mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=801000 && numero <810000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "oitocentos e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                }
                if(numero >=810000 && numero<900000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "oitocentos e ";
                    retorno += dezenaMilhar.DezenaMilharPorExtenso(Convert.ToInt32(und));
                }
                return retorno;
            }  
            if (numero >= 900000 && numero<1000000)
            {
                if (numero == 900000)
                    return "novecentos mil";
                if (numero>=900001 && numero <900010)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "novecentos mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if (numero>=900010 && numero <900100)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "novecentos mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=900100 && numero <901000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "novecentos mil e ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
                if (numero>=901000 && numero <910000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "novecentos e ";
                    retorno += unidadeMilhar.UnidadeMilharPorExtenso(Convert.ToInt32(und));
                }
                if(numero >=910000 && numero<1000000)
                {
                    string und = numero.ToString().Substring(1,5);
                    retorno = "novecentos e ";
                    retorno += dezenaMilhar.DezenaMilharPorExtenso(Convert.ToInt32(und));
                }
                return retorno;
            }  
            
            else
                return "número inválido";
        }
    }
}