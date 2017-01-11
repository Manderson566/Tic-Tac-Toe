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
                string Player1;
                string Player2;

                Console.WriteLine("Player One Enter Your Name And Press Enter.");
                Player1 = Console.ReadLine();
                Console.WriteLine("Player Two Enter Your Name And Press Enter.");
                Player2 = Console.ReadLine();
                Console.WriteLine($"Welcome {Player1} you are X. Please select a number that corrosponds to the space you want");

            }
            for (int i = 0; i < 20; i++)
            {


                string[] Lines = {"",
                              ""};
                {
                    string[] Board =
                    {"__________0","__________1","__________2","__________3","__________4","__________5","__________6","__________7","__________8"};
                    {
                        int counter = 0;
                        foreach (string Place in Board)
                        {
                            Console.Write("     " + Place);
                            if (counter == 2)

                            {
                                Console.Out.NewLine = "\r\n\r\n";
                                foreach (string Line in Lines)
                                {
                                    Console.WriteLine(Line);
                                    counter = 0;
                                }
                            }
                            else
                            {
                                counter++;
                            }
                        }
                    }
                    
                        int PlayerEntry = int.Parse(Console.ReadLine());
                        Board[PlayerEntry] = "___X___";
                        Console.Clear();
                         
                    
                    if (PlayerEntry > 8)
                    {
                        Console.WriteLine("Please choose another entry");
                    }

                }








            }

        }

    }
}


