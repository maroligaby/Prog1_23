namespace NumeroExtenso
{
    public class Unidade
    {
        public string UnidadePorExtenso (int numero) 
        {
            if(numero==0)
                return "zero";

            else if (numero==1)
                return"um";    
            
            else if (numero==2)
                return"dois";

            else if (numero==3)
                return"três";
                
            else if (numero==4)
                return"quatro";
                
            else if (numero==5)
                return"cinco";
                
            else if (numero==6)
                return"seis";
                
            else if (numero==7)
                return"sete";
                
            else if (numero==8)
                return"oito";
                
            else if (numero==9)
                return"nove";
            else
                return "número inválido";

        }
        


    }
}