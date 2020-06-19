using System;

namespace doadorsanguineo
{
    class Program
    {
        static void Main(string[] args)
        {
        //Solicite a idade do usuário. Avalie se ele pode ser doador de sangue (i.e. possui idade entre 18 e 67 anos). 
        //Informe o resultado da avaliação.
        //Qual a sua idade: 35
        //Você pode ser doador de sangue.
        //Qual a sua idade: 12
        //Você não pode ser doador de sangue.
        //Qual a sua idade: 80
        //Você não pode ser doador de sangue.
        
         int resultado;
         string idade12;
                 
         
            Console.Write("Digite sua idade: ");
            idade12 = Console.ReadLine();
            resultado = int.Parse(idade12);

                       
            if(resultado<=17){
                Console.WriteLine(" Você não pode ser doador");
           
            }
            if(resultado>=18&& resultado<=67)
            {
            Console.WriteLine(" Você pode ser doador de sangue");
           }
            if(resultado>67)
            {
            Console.WriteLine(" Você não pode ser doador de sangue");

            }
            
         
            



        }
    }
}
