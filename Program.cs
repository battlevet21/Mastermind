using System;
using System.Linq;

namespace Mastermind_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int turn = 0;
            bool hasWon = false;
            string input;
            string code = GenerateCode();
            const int maximumTurns = 10;
            while (turn <= maximumTurns)
            {
                
                Console.WriteLine($"You have {maximumTurns + 1 - turn} turn(s) left.");
                Console.WriteLine("Guess the code (for example, 1561): ");
                input = Console.ReadLine();
                if (!ValidateInput(input))
                    continue; 
                if (input == code)
                {
                  hasWon = true;
                  break;
                }

                WriteHints(input, code);
                Console.WriteLine();
                Console.Write("Press any key to continue.");
                Console.ReadKey(true);
                turn++;
            }
            Console.Clear();
            if (hasWon == true) { Console.WriteLine("You won! The code you guessed was {0}.", code); } else { Console.WriteLine("You lost! The code you couldnt guess was {0}.", code); };
            Console.ReadKey(true);
        }

        static bool ValidateInput(string input)
        {
            int number;
            return input.Length == 4 && int.TryParse(input, out number);
        }

        static Random random = new Random();
        static string GenerateCode()
        {
            return random.Next(1, 6).ToString() +
            random.Next(1, 6).ToString() +
            random.Next(1, 6).ToString() +
            random.Next(1, 6).ToString();
        }

        static void WriteHints(string input, string code)
        {
            for (int i = 0; i < input.Length; i += 1)
            {
                if (code.Contains(input[i]) && input[i] != code[i])
                    Console.Write('-');
                else if (input[i] == code[i])
                    Console.Write('+');
                else
                    Console.Write(' ');
            }
        }
    }

    class Test
    {
        public void Test()
        {
            Console.WriteLine("This class is a test class for azure purposes");
        }
        
    }
}






