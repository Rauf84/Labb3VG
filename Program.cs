using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;

namespace Labb3VG
{
    class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int MAXIMIZE = 3;

        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            SpecMonster.AddMonster();
            Welcome();
            Console.Clear();
            ChoiseAvatar();
            Menu();
            ShowByeBye();
        }
        public static string playerName;
        public static int myAvatar;
        public static int choise;
        public static string Welcome()
        {
            
            Levels.PrintInTheMiddle("************************");
            Levels.PrintInTheMiddle("* Welcome to The Game! *");
            Levels.PrintInTheMiddle("************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Levels.PrintInTheMiddle("(q) = Quit");
            Console.SetCursorPosition((Console.WindowWidth - "************************".Length) / 2, Console.CursorTop);
            Console.Write("Enter your name: ");
            playerName = Console.ReadLine();
            Console.Clear();
            return playerName;
        }

        public static void Menu()
        {
            while (choise != 4)
            {
                if (MyPlayer.Hp == 0)
                {
                    Levels.PrintInTheMiddle("Let's try again " + MyPlayer.Name);
                    SpecMonster.AddMonster();
                    ResetPlayer();
                    ResetMonsters();
                    ShowDetails();
                    Console.WriteLine();
                    keepPlaing = true;
                }
                ShowMeny();

                switch (choise)
                {
                    case 1:
                        Console.Clear();
                        if (MyPlayer.Hp == 0)
                        {
                            
                            
                        }
                        Play();
                        break;
                    case 2:
                        ShowDetails();
                        break;
                    case 3:
                        Shoping.Shoping1();
                        break;
                    case 4:
                        Console.Clear();
                        keepPlaing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Press any key to try again.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

        }

        private static void ResetMonsters()
        {
            for (int i = 0; i < SpecMonster.listOfMonsters.Count; i++)
            {
                SpecMonster.listOfMonsters[i].Hp = 100;
            }
        }

        private static void ResetPlayer()
        {
            MyPlayer.Level = 1;
            MyPlayer.Exp = 0;
            MyPlayer.Hp = 100;
            MyPlayer.Gold = 0;
            MyPlayer.Strength = 10;
            MyPlayer.Toughness = 2;
        }

        public static void ShowMeny()
        {
            string s = "Lets play: ";
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine("1. Go adventuring");
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine("2. Show details about your character");
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine("3. Go to the shop");
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine("4. Exit the game");
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.Write("Enter your choise here: ");
            choise = Convert.ToInt32(Console.ReadLine());
        }

        public static void ShowByeBye()
        {
            Levels.PrintInTheMiddle(" .----------------.  .----------------.  .----------------.   .----------------.  .----------------.  .----------------. ");
            Levels.PrintInTheMiddle("| .--------------. || .--------------. || .--------------. | | .--------------. || .--------------. || .--------------. |");
            Levels.PrintInTheMiddle("| |   ______     | || |  ____  ____  | || |  _________   | | | |   ______     | || |  ____  ____  | || |  _________   | |");
            Levels.PrintInTheMiddle("| |  |_   _ \\    | || | |_  _||_  _| | || | |_   ___  |  | | | |  |_   _ \\    | || | |_  _||_  _| | || | |_   ___  |  | |");
            Levels.PrintInTheMiddle("| |    | |_) |   | || |   \\ \\  / /   | || |   | |_  \\_|  | | | |    | |_) |   | || |   \\ \\  / /   | || |   | |_  \\_|  | |");
            Levels.PrintInTheMiddle("| |    |  __'.   | || |    \\ \\/ /    | || |   |  _|  _   | | | |    |  __'.   | || |    \\ \\/ /    | || |   |  _|  _   | |");
            Levels.PrintInTheMiddle("| |   _| |__) |  | || |    _|  |_    | || |  _| |___/ |  | | | |   _| |__) |  | || |    _|  |_    | || |  _| |___/ |  | |");
            Levels.PrintInTheMiddle("| |  |_______/   | || |   |______|   | || | |_________|  | | | |  |_______/   | || |   |______|   | || | |_________|  | |");
            Levels.PrintInTheMiddle("| |              | || |              | || |              | | | |              | || |              | || |              | |");
            Levels.PrintInTheMiddle("| '--------------' || '--------------' || '--------------' | | '--------------' || '--------------' || '--------------' |");
            Levels.PrintInTheMiddle(" '----------------'  '----------------'  '----------------'   '----------------'  '----------------'  '----------------' ");
        }

        public static bool keepPlaing = true;
        static void Play()
        {
            while (keepPlaing)
            {
                Levels.Level1();
            }



        }

        public static void ShowDetails()
        {
            switch (myAvatar)
            {
                case 1:
                    Levels.PrintInTheMiddle("              __)),        ");
                    Levels.PrintInTheMiddle("            //_ _)         ");
                    Levels.PrintInTheMiddle("            ( 'V')         ");
                    Levels.PrintInTheMiddle("             \\_-/         ");
                    Levels.PrintInTheMiddle("         ,---/  '---.      ");
                    Levels.PrintInTheMiddle("        /     - -    \\    ");
                    Levels.PrintInTheMiddle("       /  \\_. _|__,/  \\  ");
                    Levels.PrintInTheMiddle("      /  )\\        )\\_ \\");
                    Levels.PrintInTheMiddle("     / _/  (   '  ) /  /   ");
                    Levels.PrintInTheMiddle("    / |     (_____) | /    ");
                    Levels.PrintInTheMiddle("   /,'      /     \\/ /,   ");
                    Levels.PrintInTheMiddle(" _/(_      (   ._, )-'     ");
                    Levels.PrintInTheMiddle("`--,/      |____|__|       ");
                    break;
                case 2:
                    Levels.PrintInTheMiddle("         ____");
                    Levels.PrintInTheMiddle("        /((   ))");
                    Levels.PrintInTheMiddle("       ( )6  6( )");
                    Levels.PrintInTheMiddle("       (_)  l (_)");
                    Levels.PrintInTheMiddle("       \\ <>/");
                    Levels.PrintInTheMiddle("       ____) (_____");
                    Levels.PrintInTheMiddle("       (   \\____/   )");
                    Levels.PrintInTheMiddle("       ) (   )(   ) (");
                    Levels.PrintInTheMiddle("     / / \\      / \\ \\");
                    Levels.PrintInTheMiddle("     / /   \\    /   \\ \\");
                    Levels.PrintInTheMiddle("    \\ \\    )==(    / /");
                    Levels.PrintInTheMiddle("     \\ \\  /    \\  / /");
                    Levels.PrintInTheMiddle("`    '\\ \\/      \\//'");
                    
                    break;
            }

            string d1="______________________________";
            string d2="Name: "+ playerName;
            string d3="Level: " + MyPlayer.Level;
            string d4="Experience: " + MyPlayer.Exp;
            string d5="Health points: " + MyPlayer.Hp;
            string d6="Gold: " +  MyPlayer.Gold;
            string d7="Strength: " + MyPlayer.Strength;
            string d8="Toughness: " + MyPlayer.Toughness;
            Levels.PrintInTheMiddle(d1);
            Levels.PrintInTheMiddle(d2);
            Levels.PrintInTheMiddle(d3);
            Levels.PrintInTheMiddle(d4);
            Levels.PrintInTheMiddle(d5);
            Levels.PrintInTheMiddle(d6);
            Levels.PrintInTheMiddle(d7);
            Levels.PrintInTheMiddle(d8);
            Levels.PrintInTheMiddle(Levels.pressEnter);
            Console.ReadKey();
            Console.Clear();
        }

        public static void ChoiseAvatar()
        {
            Console.Clear();
            string s = "Hi " + playerName + ". Please choise your avatar [1 or 2]";
            Console.SetCursorPosition((Console.WindowWidth - (s.Length + playerName.Length)) / 2, Console.CursorTop);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (s.Length + playerName.Length)) / 2, Console.CursorTop);

            Levels.PrintInTheMiddle("                      Avatar 1                                 Avatar 2             ");
            Levels.PrintInTheMiddle("            __)),                                  ____");
            Levels.PrintInTheMiddle("           //_ _)                                  /((   ))");
            Levels.PrintInTheMiddle("            ( 'V')                                 ( )6  6( )");
            Levels.PrintInTheMiddle("             \\_-/                                  (_)  l (_)");
            Levels.PrintInTheMiddle("      ,---/  '---.                                \\ <>/");
            Levels.PrintInTheMiddle("        /     - -    \\                            ____) (_____");
            Levels.PrintInTheMiddle("       /  \\_. _|__,/  \\                          (   \\____/   )");
            Levels.PrintInTheMiddle("      /  )\\        )\\_ \\                         ) (   )(   ) (");
            Levels.PrintInTheMiddle("     / _/  (   '  ) /  /                         / / \\      / \\ \\");
            Levels.PrintInTheMiddle("    / |     (_____) | /                         / /   \\    /   \\ \\");
            Levels.PrintInTheMiddle("   /,'      /     \\/ /,                         \\ \\    )==(    / /");
            Levels.PrintInTheMiddle(" _/(_      (   ._, )-'                           \\ \\  /    \\  / /");
            Levels.PrintInTheMiddle("`--,/     |____|__|                              '\\ \\/      \\//'");

            myAvatar = Convert.ToInt32(Console.ReadLine());
            ShowDetails();
        }

        //public Player(string name, int avatar, int hp, int exp, int gold, int level, int strength, int toughness)
        public static Player MyPlayer  = new Player(playerName, myAvatar, 100, 0, 0, 1, 10, 2); 

    }
}
