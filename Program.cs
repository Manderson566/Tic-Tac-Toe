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
                string Instructions = "Enter the number that corrosponds to the space you want";


                Console.WriteLine(Instructions);
            }
            string[] board = {
                "______0", "______1", "______2", "______3", "______4", "______5", "______6", "______7", "______8"
        };

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
            
                for (int i = 0; i < 9; i++) 

                { 
            string[] board2 = {
                "______0", "______1", "______2", "______3", "______4", "______5", "______6", "______7", "______8"
        };
            {
                int Player = int.Parse(Console.ReadLine());
                board2[Player] = "___X___";
            }


            int counter2 = 0;
                foreach (string place2 in board2)
                {
                    Console.Write(" " + place2);
                    if (counter2 == 2)
                    {
                        Console.WriteLine("");
                        counter2 = 0;

                    }
                    else
                    {
                        counter2++;

                    }
                }
       

            }

        }
    }
}




