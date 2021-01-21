using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG
{
    class Shoping
    {
        public static void Shoping1()
        {
            Console.WriteLine();
            Levels.PrintInTheMiddle("Welcome to the shop");
            bool keepShopping = true;
            while (keepShopping)
            {
                Console.WriteLine();
                Levels.PrintInTheMiddle($"You have {Program.MyPlayer.Gold} coins");
                Levels.PrintInTheMiddle("Enter q to go back to the game");
                Console.WriteLine();
                Levels.PrintInTheMiddle("=================================");
                Levels.PrintInTheMiddle("|   Product        |  Price     |");
                Levels.PrintInTheMiddle("=================================");
                Levels.PrintInTheMiddle("| 1. + 100% hp     |  10 coins  |");
                Levels.PrintInTheMiddle("| 2. + 10 strength |  10 coins  |");
                Levels.PrintInTheMiddle("| 3. + 10 toughness|  10 coins  |");
                Levels.PrintInTheMiddle("=================================");
                Console.SetCursorPosition((Console.WindowWidth - "Enter you choise here: ".Length)/2,Console.CursorTop);
                Console.Write("Enter your choise here: ");
                string shopChoise = Console.ReadLine();
                switch (shopChoise)
                {
                    case "1":
                        Program.MyPlayer.Hp += 100;
                        Program.MyPlayer.Gold -= 10;
                        break;
                    case "2":
                        Program.MyPlayer.Strength += 10;
                        Program.MyPlayer.Gold -= 10;
                        break;
                    case "3":
                        Program.MyPlayer.Toughness += 10;
                        Program.MyPlayer.Gold -= 10;
                        break;
                    case "q":
                        Console.Clear();
                        keepShopping = false;
                        break;
                    default:
                        Levels.PrintInTheMiddle("Wrong choise, please try again");
                        break;
                }




            }
        }
    }
}
