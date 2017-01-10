using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string Instructions = "Test";
               

                Console.WriteLine(Instructions);
            }
            string[] board = new[] {
                "______0", "______1", "______2", "______3", "______4", "______5", "______6", "______7", "______8"
        };
            {
                int Player = int.Parse (Console.ReadLine());
                board[Player] = "___X___";
            }
                int counter = 0;
                foreach (string place in board)
                    
            {
                Console.Write(" " + place);
                if (counter == 2)
                {
                    Console.WriteLine("");
                    counter = 0;

                }
                else
                {
                    counter++;
                }


                
            }
        }
    }
}

        
    

