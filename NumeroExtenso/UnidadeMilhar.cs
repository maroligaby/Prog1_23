namespace NumeroExtenso
{
    public class UnidadeMilhar
    {
       public string UnidadeMilharPorExtenso(int numero)
        {

            string retorno ="";
            Unidade unidade = new Unidade();
            Dezena dezena = new Dezena();
            Centena centena = new Centena();
            
            if (numero>=1000 && numero<2000)
            {
                if(numero==1000)
                    return "um mil";

                if (numero>=1001 && numero<1010)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "um mil e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=1010 && numero<=1099)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "um mil e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=1100 && numero<=1999)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "um mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
            }
            if (numero>=2000 && numero<3000)
            {
                if(numero==2000)
                    return "dois mil";

                if (numero>=2001 && numero<2010)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "dois mil e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=2010 && numero<=2099)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "dois mil e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=2100 && numero<=2999)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "dois mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
            }
            if (numero>=3000 && numero<4000)
            {
                if(numero==3000)
                    return "três mil";

                if (numero>=3001 && numero<3010)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "três mil e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=3010 && numero<=3099)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "três mil e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=3100 && numero<=3999)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "três mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
            }     
            if (numero>=4000 && numero<5000)
            {
                if(numero==4000)
                    return "quatro mil";

                if (numero>=4001 && numero<4010)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "quatro mil e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=4010 && numero<=4099)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "quatro mil e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=4100 && numero<=4999)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "quatro mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
            }
            if (numero>=5000 && numero<6000)
            {
                if(numero==5000)
                    return "cinco mil";

                if (numero>=5001 && numero<5010)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "cinco mil e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=5010 && numero<=5099)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "cinco mil e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=5100 && numero<=5999)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "cinco mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
            }
            if (numero>=6000 && numero<7000)
            {
                if(numero==6000)
                    return "seis mil";

                if (numero>=6001 && numero<6010)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "seis mil e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=6010 && numero<=6099)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "seis mil e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=6100 && numero<=6999)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "seis mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
            }
            if (numero>=7000 && numero<8000)
            {
                if(numero==7000)
                    return "sete mil";

                if (numero>=7001 && numero<7010)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "sete mil e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=7010 && numero<=7099)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "sete mil e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=7100 && numero<=7999)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "sete mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
            }
            if (numero>=8000 && numero<9000)
            {
                if(numero==8000)
                    return "oito mil";

                if (numero>=8001 && numero<8010)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "oito mil e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=8010 && numero<=8099)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "oito mil e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=8100 && numero<=8999)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "oito mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
            }
            if (numero>=9000 && numero<10000)
            {
                if(numero==9000)
                    return "nove mil";

                if (numero>=9001 && numero<9010)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "nove mil e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=9010 && numero<=9099)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "nove mil e ";
                    retorno +=  dezena.DezenaPorExtenso(Convert.ToInt32(und));
                } 
                if (numero>=9100 && numero<=9999)
                {
                    string und = numero.ToString().Substring(1,3);
                    retorno = "nove mil e ";
                    retorno +=  centena.CentenaPorExtenso(Convert.ToInt32(und));
                } 
                return retorno;
            }
            else
                return "número inválido";
        }

 
    }
}