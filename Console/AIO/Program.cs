using System;
using System.Collections.Generic;
using System.Linq;
using AuthGG;
using System.Text;
using System.Threading.Tasks;

namespace MadBunny_Spoofer
{
    class Program
    {
        static void Main(string[] args)
        {
            OnProgramStart.Initialize("MadBunny", "679462", "TUZUpB3iaGXmolkEXO2DM4pvDZc6Bt81Y6i", "1.0");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter your auth key: ");
            string input = Console.ReadLine();

            if (AuthGG.API.AIO(input))
            {
            
                // CODE WHEN LOGIN IS VALID
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid!");
            }
            else
            {
                // CODE WHEN LOGIN IS INVALID
            
                Console.WriteLine("Login Failed!");
            }
            Console.ReadLine();

        }
    }
}
