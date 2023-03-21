namespace NumeroExtenso
{
    public class Centena
    {
        public string CentenaPorExtenso (int numero) 
        {
            if (numero>99 && numero<200)
                return "cento e ";
            
            if (numero>199 && numero<300)
                return "duzentos e ";
                
            if (numero>299 && numero<400)
                return "trezentos e ";
            
            if (numero>399 && numero<500)
                return "quatrocentos e ";
                
            if (numero>499 && numero<600)
                return "quinhentos e ";
                
            if (numero>599 && numero<700)
                return "seiscentos e ";
                
            if (numero>699 && numero<800)
                return "setecentos e ";
                
            if (numero>799 && numero<900)
                return "oitocentos e ";

            if (numero>899 && numero<1000)
                return "novecentos e ";    
            else
                return "número inválido";
    }
}
}