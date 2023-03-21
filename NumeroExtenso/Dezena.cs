namespace NumeroExtenso
{
    public class Dezena
    {
        public string DezenaPorExtenso (int numero) 
        {
            string retorno ="";
            Unidade unidade = new Unidade();

            if(numero==10)
                return "dez";

            if (numero==11)
                return"onze";    
            
            if (numero==12)
                return"doze";

            if (numero==13)
                return"treze";
                
            if (numero==14)
                return"quatorze";
                
            if (numero==15)
                return"quinze";
                
            if (numero==16)
                return"dezesseis";
                
            if (numero==17)
                return"dezessete";
                
            if (numero==18)
                return"dezoito";
                
            if (numero==19)
                return"dezenove";

            if (numero>=20 && numero<30)
            {
                if (numero ==20)
                    return "vinte";
                else 
                {
                    string und = numero.ToString().Substring(1,1);
                    retorno = "vinte e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
            

            if (numero>=30 && numero<40)
            {
                if (numero ==30)
                    return "trinta";
                else 
                {
                    string und = numero.ToString().Substring(1,1);
                    retorno = "trinta e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
                
            if (numero>=40 && numero<50)
            {
                if (numero ==40)
                    return "quarenta";
                else 
                {
                    string und = numero.ToString().Substring(1,1);
                    retorno = "quarenta e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
            
            if (numero>=50 && numero<60)
            {
                if (numero ==50)
                    return "cinquenta";
                else 
                {
                    string und = numero.ToString().Substring(1,1);
                    retorno = "cinquenta e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
                
            if (numero>=60 && numero<70)
            {
                if (numero ==60)
                    return "sessenta";
                else 
                {
                    string und = numero.ToString().Substring(1,1);
                    retorno = "sessenta e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
                
            if (numero>=70 && numero<80)
            {
                if (numero ==70)
                    return "setenta";
                else 
                {
                    string und = numero.ToString().Substring(1,1);
                    retorno = "setenta e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
                
            if (numero>=80 && numero<90)
            {
                if (numero ==80)
                    return "oitenta";
                else 
                {
                    string und = numero.ToString().Substring(1,1);
                    retorno = "oitenta e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
                
            if (numero>=90 && numero<100)
                {
                if (numero ==90)
                    return "noventa";
                else 
                {
                    string und = numero.ToString().Substring(1,1);
                    retorno = "noventa e ";
                    retorno +=  unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }    
                return retorno;
            }
            else
                return "número inválido";
        
         
    }
}
}