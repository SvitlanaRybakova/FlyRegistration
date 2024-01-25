using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sectors = { 6, 28, 15, 15, 18 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < sectors.Length; i++)
                {

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"In sector {i + 1} available {sectors[i]} seats");
                }

                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The fly registration");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n1 - buy the seat(s) \n\n2 - exit the program");
                Console.WriteLine("\n\nPlease, enter the number of command: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        break;
                    case 2:
                        isOpen = true;
                        break;
                }
            }
        }
    }
}
