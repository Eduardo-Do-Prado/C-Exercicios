using System;

namespace _numeros_impares
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = 1;
           
            while(x <= 100)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine("{0}",x);
                }

                x++;
            }
        }
    }
}






    

