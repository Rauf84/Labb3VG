using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG
{
    public class Levels
    {
        public static void Level1()
        {
            string level1 = "Level 1";
            string pressEnter = "[Press enter to continue]";
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
            Console.WriteLine("Hi {0}. ",Program.playerName);


           
        }

        public static void Level2()
        {
            Console.WriteLine("Level 2");
            Console.ReadKey();
        }


    }
}
