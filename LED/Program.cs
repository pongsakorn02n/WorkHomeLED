using Microsoft.VisualBasic;
using System;
using System.IO;

namespace LED
{
    class Program : IHomework05
    {

        static String[] data = new string[10];

        static void Main(string[] args)
        {
            String input = null;

            Program program = new Program();

            Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
            Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");

            while (input != "exit")
            {
                Console.Write("Please choose LED to turn On/Off: ");
                input = Console.ReadLine();
                if (input != null)
                {
                    program.DisplayLEDOnScreen(input);
                }// end if input != null
            }// end for
        }

        public string DisplayLEDOnScreen(String ledNo)
        {
            String input = ledNo;            

            if (input != null)
            {
                int index;
                if (input == "A")
                {
                    index = 9;
                }
                else
                {
                    index = Int16.Parse(input) - 1;
                }

                if (index >= 0 && index <= 9)
                {
                    if(data[index] == "!")
                    {
                        data[index] = "";
                    }
                    else
                    {
                        data[index] = "!";
                    }

                    foreach (String item in data)
                    {
                        Console.Write(" [{0}] ", item);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("  1   2   3   4   5   6   7   8   9   A");
                    Console.WriteLine(" ");
                }
            }// end if input != null

            return input;
        }
    }
}
