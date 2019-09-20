using System;

namespace Par_ou_ímpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            

            
            do{
            

            Console.WriteLine("Digite um número inteiro: ");
            x = double.Parse (Console.ReadLine());

            if (x % 2 == 0){
            Console.WriteLine("Esse número é par");}
    
            else{
            Console.WriteLine("Esse número é ímpar");}

            Console.WriteLine("(1) para ir novamente ou (0) para sair");
            fx = Console.ReadLine();}

            while(fx == "(1)");                
            
        }
    }
}
