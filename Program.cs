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
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"In sector {i + 1} available {sectors[i]} seats");
                }

                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The fly registration");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n1 - buy the seat(s) \n\n2 - exit the program");
                Console.Write("\n\nPlease, enter the number of command: ");

                int userCommand;
                if (!GetValidInput(Console.ReadLine(), out userCommand, 1, 2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid command. Please enter a valid number (1 or 2).");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch (userCommand)
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write("Which sector would you like to fly?: ");
                        if (!GetValidInput(Console.ReadLine(), out userSector, 1, sectors.Length) || userSector <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid sector. Please enter a valid sector number.");
                            break;
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("How many seats do you want to buy?: ");
                        if (!GetValidInput(Console.ReadLine(), out userPlaceAmount, 0, sectors[userSector - 1]) || userPlaceAmount <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Invalid input. Please enter a valid number of seats (1 to {sectors[userSector - 1]}).");
                            break;
                        }

                        sectors[userSector - 1] -= userPlaceAmount;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Congrats, you have bought {userPlaceAmount} seat(s) in sector {userSector}.");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bye! Press any key to exit the program");
                        isOpen = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static bool GetValidInput(string userInput, out int result, int minValue, int maxValue)
        {
            return int.TryParse(userInput, out result) && result >= minValue && result <= maxValue;
        }
    }
}
