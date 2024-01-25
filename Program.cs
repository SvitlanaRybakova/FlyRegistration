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


                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmmount;
                        Console.Write("Witch sector would you like to fly?: ");
                        userSector = Convert.ToInt32(Console.ReadLine()) -1;

                        if(sectors.Length <= userSector || userSector < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The specified sector is non-existent.");
                            break;
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("How many seats do you want to buy?: ");
                        userPlaceAmmount = Convert.ToInt32(Console.ReadLine());

                        if (sectors[userSector] < userPlaceAmmount || userPlaceAmmount < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The sector {userSector + 1} does not have enough seats. The remaining seats are {sectors[userSector]}.");
                            break;
                        }
                        sectors[userSector] -= userPlaceAmmount;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Congrats, you have bought the {userPlaceAmmount} seats in the {userSector + 1} sector.");
                        break;
                    case 2:
                        Console.WriteLine("Bye! Press the enter to exit the program");
                        isOpen = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
