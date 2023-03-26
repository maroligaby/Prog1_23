namespace NumeroExtenso
{
    public class Centena
    {
        public string CentenaPorExtenso (int numero) 
        {
            string retorno ="";
            Dezena dezena = new Dezena();
            Unidade unidade = new Unidade();

            if (numero>=100 && numero<200)
            {
                if (numero==100)
                    return "cem";

                if (numero>=101 && numero<110) 
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "cento e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    

                else
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "cento e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                return retorno;

            }
            
            if (numero>=200 && numero<300)
            {
                if (numero==200)
                    return "duzentos";

                if (numero>=201 && numero<210) 
                {
                    string und = numero.ToString().Substring(2,1);
                    retorno = "duzentos e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    

                else
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "duzentos e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                return retorno;

            }
            if (numero>=300 && numero<400)
            {
                if (numero==300)
                    return "trezentos";

                if (numero>=301 && numero<310) 
                {
                    string und = numero.ToString().Substring(2,1);
                    retorno = "trezentos e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    

                else
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "trezentos e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                return retorno;

            }
            if (numero>=400 && numero<500)
            {
                if (numero==400)
                    return "quatrocentos";

                if (numero>=401 && numero<410) 
                {
                    string und = numero.ToString().Substring(2,1);
                    retorno = "quatrocentos e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    

                else
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "quatrocentos e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                return retorno;

            }
            if (numero>=500 && numero<600)
            {
                if (numero==500)
                    return "quinhentos";

                if (numero>=501 && numero<510) 
                {
                    string und = numero.ToString().Substring(2,1);
                    retorno = "quinhentos e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    

                else
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "quinhentos e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                return retorno;

            }
            if (numero>=600 && numero<700)
            {
                if (numero==600)
                    return "seiscentos";

                if (numero>=601 && numero<610) 
                {
                    string und = numero.ToString().Substring(2,1);
                    retorno = "seiscentos e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    

                else
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "seiscentos e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                return retorno;

            }
            if (numero>=700 && numero<800)
            {
                if (numero==700)
                    return "setecentos";

                if (numero>=701 && numero<710) 
                {
                    string und = numero.ToString().Substring(2,1);
                    retorno = "setecentos e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    

                else
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "setecentos e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                return retorno;

            }
            if (numero>=800 && numero<900)
            {
                if (numero==800)
                    return "oitocentos";

                if (numero>=801 && numero<810) 
                {
                    string und = numero.ToString().Substring(2,1);
                    retorno = "oitocentos e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    

                else
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "oitocentos e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                return retorno;

            }
            if (numero>=900 && numero<1000)
            {
                if (numero==900)
                    return "novecentos";

                if (numero>=901 && numero<910) 
                {
                    string und = numero.ToString().Substring(2,1);
                    retorno = "novecentos e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    

                else
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "novecentos e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                return retorno;

            }
            else
                return "número inválido";
    }
}
}