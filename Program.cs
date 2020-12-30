using System;
using System.ComponentModel.Design;

namespace Labb3VG
{
    class Program
    {
        static string s = "* Welcome to The Game! *";
        static void Main(string[] args)
        {
            Welcome();
            Console.Clear();
            Menu();
        }

        public static void Welcome()
        {
            
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine("************************");
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine("************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
        }

        public static void Menu()
        {
            int choise = 0;
            while (choise != 3)
            {
                Console.WriteLine("Lets play: \n" +
                            "\n1. Go adventuring" +
                            "\n2. Show details about your character" +
                            "\n3. Exit game" +
                            "\nEnter your choise here: ");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Play();
                        break;
                    case 2:
                        ShowDetails();
                        break;
                    case 3:
                        Console.WriteLine(" .----------------.  .----------------.  .----------------.   .----------------.  .----------------.  .----------------. ");
                        Console.WriteLine("| .--------------. || .--------------. || .--------------. | | .--------------. || .--------------. || .--------------. |");
                        Console.WriteLine("| |   ______     | || |  ____  ____  | || |  _________   | | | |   ______     | || |  ____  ____  | || |  _________   | |");
                        Console.WriteLine("| |  |_   _ \\    | || | |_  _||_  _| | || | |_   ___  |  | | | |  |_   _ \\    | || | |_  _||_  _| | || | |_   ___  |  | |");
                        Console.WriteLine("| |    | |_) |   | || |   \\ \\  / /   | || |   | |_  \\_|  | | | |    | |_) |   | || |   \\ \\  / /   | || |   | |_  \\_|  | |");
                        Console.WriteLine("| |    |  __'.   | || |    \\ \\/ /    | || |   |  _|  _   | | | |    |  __'.   | || |    \\ \\/ /    | || |   |  _|  _   | |");
                        Console.WriteLine("| |   _| |__) |  | || |    _|  |_    | || |  _| |___/ |  | | | |   _| |__) |  | || |    _|  |_    | || |  _| |___/ |  | |");
                        Console.WriteLine("| |  |_______/   | || |   |______|   | || | |_________|  | | | |  |_______/   | || |   |______|   | || | |_________|  | |");
                        Console.WriteLine("| |              | || |              | || |              | | | |              | || |              | || |              | |");
                        Console.WriteLine("| '--------------' || '--------------' || '--------------' | | '--------------' || '--------------' || '--------------' |");
                        Console.WriteLine(" '----------------'  '----------------'  '----------------'   '----------------'  '----------------'  '----------------' ");
                        break;
                default:
                        Console.WriteLine("Invalid input. Press any key to try again.");
                        Console.ReadKey();
                        Console.Clear();
                break;
                }
            }

        }

        static void Play()
        {

        }

        static void ShowDetails()
        {

        }
    }
}
