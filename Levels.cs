using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG
{
    public class Levels
    {
            public static string pressEnter = "[Press enter to continue]";
        public static void Level1()
        {
            string level1 = "Level 1";
            string center = " _______  _______  _______  _______  _______ _________";
            Console.SetCursorPosition((Console.WindowWidth - level1.Length) / 2, Console.CursorTop);
            Console.WriteLine(level1);
            Console.SetCursorPosition((Console.WindowWidth - center.Length) / 2, Console.CursorTop);
            Console.WriteLine(center);
            Console.SetCursorPosition((Console.WindowWidth - center.Length) / 2, Console.CursorTop);
            Console.WriteLine("(  ____ \\(  ___  )(  ____ )(  ____ \\(  ____ \\__   __/");
            Console.SetCursorPosition((Console.WindowWidth - center.Length) / 2, Console.CursorTop);
            Console.WriteLine("| (    \\/| (   ) || (    )|| (    \\/| (    \\/   ) (   ");
            Console.SetCursorPosition((Console.WindowWidth - center.Length) / 2, Console.CursorTop);
            Console.WriteLine("| (__    | |   | || (____)|| (__    | (_____    | |   ");
            Console.SetCursorPosition((Console.WindowWidth - center.Length) / 2, Console.CursorTop);
            Console.WriteLine("|  __)   | |   | ||     __)|  __)   (_____  )   | |   ");
            Console.SetCursorPosition((Console.WindowWidth - center.Length) / 2, Console.CursorTop);
            Console.WriteLine("| (      | |   | || (\\ (   | (            ) |   | |   ");
            Console.SetCursorPosition((Console.WindowWidth - center.Length) / 2, Console.CursorTop);
            Console.WriteLine("| )      | (___) || ) \\ \\__| (____/\\/\\____) |   | |   ");
            Console.SetCursorPosition((Console.WindowWidth - center.Length) / 2, Console.CursorTop);
            Console.WriteLine("|/       (_______)|/   \\__/(_______/\\_______)   )_(   ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - pressEnter.Length) / 2, Console.CursorTop);
            Console.WriteLine(pressEnter);
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - Program.playerName.Length)/2, Console.CursorTop);
            Console.WriteLine("Hi {0}. ",Program.playerName);


           
        }

        public static void Level2()
        {
            Console.WriteLine("Level 2");
            Console.WriteLine("...............");
            Console.WriteLine("Level 2 is done");
            Console.ReadKey();
        }

        public static void Level3() 
        {
            Console.WriteLine("Level 3");
            Console.WriteLine("...............");
            Console.WriteLine("Level 3 is done");
            Console.ReadKey();
        }
        public static void Level4() 
        {
            Console.WriteLine("Level 4");
            Console.WriteLine("...............");
            Console.WriteLine("Level 4 is done");
            Console.ReadKey();
        }
        public static void Level5() 
        {
            Console.WriteLine("Level 5");
            Console.WriteLine("...............");
            Console.WriteLine("Level 5 is done");
            Console.ReadKey();
        }
        public static void Level6() 
        {
            Console.WriteLine("Level 6");
            Console.WriteLine("...............");
            Console.WriteLine("Level 6 is done");
            Console.ReadKey();
        }
        public static void Level7() 
        {
            Console.WriteLine("Level 7");
            Console.WriteLine("...............");
            Console.WriteLine("Level 7 is done");
            Console.ReadKey();
        }
        public static void Level8() 
        {
            Console.WriteLine("Level 8");
            Console.WriteLine("...............");
            Console.WriteLine("Level 8 is done");
            Console.ReadKey();
        }
        public static void Level9() 
        {
            Console.WriteLine("Level 9");
            Console.WriteLine("...............");
            Console.WriteLine("Level 9 is done");
            Console.ReadKey();
        }
        public static void Level10() 
        {
            Console.WriteLine("Level 10");
            Console.WriteLine("...............");
            Console.WriteLine("Level 10 is done");
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - 20)/2,Console.CursorTop);
            Console.WriteLine("YOU WON THE GAME !!!");
            Console.SetCursorPosition((Console.WindowWidth - (Program.playerName.Length+17)) / 2, Console.CursorTop);
            Console.WriteLine("CONGRATULATIONS, {0}!",Program.playerName);
            Console.SetCursorPosition((Console.WindowWidth - pressEnter.Length) / 2, Console.CursorTop);
            Console.WriteLine(pressEnter);
            Console.ReadKey();
            Console.Clear();
            Program.Welcome();
        }



    }
}
