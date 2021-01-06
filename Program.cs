﻿using System;
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

            ChoiseAvatar();

            Menu();
        }
        public static string playerName;
        public static int myAvatar;

        public static string Welcome()
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
            playerName = Console.ReadLine();
            Console.Clear();
            string welcomePlayer = "Welcome to the game " + playerName;
            Console.SetCursorPosition((Console.WindowWidth - welcomePlayer.Length)/2, Console.CursorTop);
            return playerName;
        }

        public static void Menu()
        {
            int choise = 0;
            while (choise != 3)
            {
                Console.Clear();
                Console.WriteLine("Lets play: \n" +
                            "\n1. Go adventuring" +
                            "\n2. Show details about your character" +
                            "\n3. Exit game");
                Console.Write("Enter your choise here: ");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.Clear();
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
            Levels.Level1();
            Levels.Level2();
            Levels.Level3();
            Levels.Level4();
            Levels.Level5();
            Levels.Level6();
            Levels.Level7();
            Levels.Level8();
            Levels.Level9();
            Levels.Level10();
            Console.WriteLine("Congratulations, YOU WON !!! ");
            Console.WriteLine(Levels.pressEnter);

        }

        static void ShowDetails()
        {
            Console.Clear();
            switch (myAvatar)
            {
                case 1:
                    Console.WriteLine("              __)),        ");
                    Console.WriteLine("            //_ _)         ");
                    Console.WriteLine("            ( 'V')         ");
                    Console.WriteLine("             \\_-/         ");
                    Console.WriteLine("         ,---/  '---.      ");
                    Console.WriteLine("        /     - -    \\    ");
                    Console.WriteLine("       /  \\_. _|__,/  \\  ");
                    Console.WriteLine("      /  )\\        )\\_ \\");
                    Console.WriteLine("     / _/  (   '  ) /  /   ");
                    Console.WriteLine("    / |     (_____) | /    ");
                    Console.WriteLine("   /,'      /     \\/ /,   ");
                    Console.WriteLine(" _/(_      (   ._, )-'     ");
                    Console.WriteLine("`--,/      |____|__|       ");
                    break;
                case 2:
                    Console.WriteLine("             ____");
                    Console.WriteLine("           /((   ))");
                    Console.WriteLine("          ( )6  6( )");
                    Console.WriteLine("          (_)  l (_)");
                    Console.WriteLine("            \\ <>/");
                    Console.WriteLine("         ____) (_____");
                    Console.WriteLine("       (   \\____/   )");
                    Console.WriteLine("       ) (   )(   ) (");
                    Console.WriteLine("      / / \\      / \\ \\");
                    Console.WriteLine("     / /   \\    /   \\ \\");
                    Console.WriteLine("    \\ \\    )==(    / /");
                    Console.WriteLine("     \\ \\  /    \\  / /");
                    Console.WriteLine("`    '\\ \\/      \\//'");
                    break;
            }
            Console.WriteLine("______________________________");
            Console.WriteLine("Name: {0}", playerName);
            Console.WriteLine("Level: {0}",MyPlayer.Level);
            Console.WriteLine("Experience: {0}",MyPlayer.Exp);
            Console.WriteLine("Health points: {0}/100",MyPlayer.Hp);
            Console.WriteLine("Gold: {0}", MyPlayer.Gold);
            Console.WriteLine("Strength: {0}", MyPlayer.Strength);
            Console.WriteLine("Toughness: {0}", MyPlayer.Toughness);
            Console.WriteLine(Levels.pressEnter);

        }

        public static void ChoiseAvatar()
        {
            Console.Clear();
            string s = "Hi " + playerName + ". Please choise your avatar [1 or 2]";
            Console.WriteLine("            "+s);
            Console.WriteLine();
            Console.WriteLine("             Avatar 1                                 Avatar 2             ");
            Console.WriteLine("              __)),                                    ____");
            Console.WriteLine("            //_ _)                                  /((   ))");
            Console.WriteLine("            ( 'V')                                  ( )6  6( )");
            Console.WriteLine("             \\_-/                                   (_)  l (_)");
            Console.WriteLine("         ,---/  '---.                                 \\ <>/");
            Console.WriteLine("        /     - -    \\                             ____) (_____");
            Console.WriteLine("       /  \\_. _|__,/  \\                          (   \\____/   )");
            Console.WriteLine("      /  )\\        )\\_ \\                          ) (   )(   ) (");
            Console.WriteLine("     / _/  (   '  ) /  /                         / / \\      / \\ \\");
            Console.WriteLine("    / |     (_____) | /                         / /   \\    /   \\ \\");
            Console.WriteLine("   /,'      /     \\/ /,                         \\ \\    )==(    / /");
            Console.WriteLine(" _/(_      (   ._, )-'                           \\ \\  /    \\  / /");
            Console.WriteLine("`--,/      |____|__|                             '\\ \\/      \\//'");

            myAvatar = Convert.ToInt32(Console.ReadLine());
            ShowDetails();
            Console.ReadKey();
        }

         public static Player MyPlayer  = new Player(playerName, myAvatar, 100, 0, 0, 1, 10, 10); 

    }
}
