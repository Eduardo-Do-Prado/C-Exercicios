using System;
using System.Collections.Generic;

namespace Vetores_N {
    class Program {
        static void Main (string[] args) { 
            string[] Vetor = new string[5];

            for(int x - 0; x < 5; x++){
                System.Console.Write($"{x}: ");
                Vetor[x] = int.Parse(Console.ReadLine());
            }
        
        for (int y = 4; y >= 0 ; y++)
        {
            System.Console.WriteLine($"{Vetor [y]} ");
        }
        }
    }
} 

#region troca
    

/* using System;
using System.Collections.Generic;

namespace Vetores_N {
    class Program {
        static void Main (string[] args) {
            string[] Vetor = new string[5];

            for (int i - 0; i < 5; i++) {

                System.Console.WriteLine ("Nome: ");
                Vetor[1] = Console.ReadLine ();
            }

            System.Console.WriteLine("Troca: ");
            string troca = Console.ReadLine();
            

            for (int y = 4; y >= 0; y--) {
                if(Vetor[y] == troca){
                    System.Console.WriteLine("Novo: ");
                    Vetor[y] = Console.ReadLine();
                    break;
                }
                System.Console.WriteLine("Não encontrei o nome.");
            }
        }
    }
} */ 
#endregion

#region foreach
/*using System;
using System.Collections.Generic;

namespace Vetores_N {
    class Program {
        static void Main (string[] args) {
            string[] Vetor = new string[5];

            for (int i - 0; i < 5; i++) {

                System.Console.WriteLine ("Nome: ");
                Vetor[1] = Console.ReadLine ();
            }

            System.Console.WriteLine("Troca: ");
            string troca = Console.ReadLine();
            

            foreach ( string n in Vetor) {
                if(Vetor[y] == troca){
                    System.Console.WriteLine($"{N}: ");
                }
            }
        }
    }
} */
#endregion