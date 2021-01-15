using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Text;

namespace Labb3VG
{
    public class Levels
    {
        public static string pressEnter = "[Press enter to continue]";
        public static void PrintInTheMiddle(string s1)
        {
            Console.SetCursorPosition((Console.WindowWidth - s1.Length) / 2, Console.CursorTop);
            Console.WriteLine(s1);
        }
        public static void Level1()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            PrintInTheMiddle("Level "+Program.MyPlayer.Level);
            /*
            PrintInTheMiddle(" _______  _______  _______  _______  _______ _________");
            PrintInTheMiddle("(  ____ \\(  ___  )(  ____ )(  ____ \\(  ____ \\__   __/");
            PrintInTheMiddle("| (    \\/| (   ) || (    )|| (    \\/| (    \\/   ) (   ");
            PrintInTheMiddle("| (__    | |   | || (____)|| (__    | (_____    | |   ");
            PrintInTheMiddle("|  __)   | |   | ||     __)|  __)   (_____  )   | |   ");
            PrintInTheMiddle("| (      | |   | || (\\ (   | (            ) |   | |   ");
            PrintInTheMiddle("| )      | (___) || ) \\ \\__| (____/\\/\\____) |   | |   ");
            PrintInTheMiddle("|/       (_______)|/   \\__/(_______/\\_______)   )_(   ");
            */

            Console.WriteLine("");
            Console.WriteLine("");
            PrintInTheMiddle(pressEnter);
            Console.ReadKey();
            Console.Clear();
            switch (Program.MyPlayer.Level)
            {
                case 1:
                    ShowMervin();
                    PrintInTheMiddle("Hi " + Program.playerName + ". I'm Mervin and I know everything about this forest. There is a Giant Wurm in the forest");
                    PrintInTheMiddle("thats why you have to be carefull.The Giant Wurm have some gold you can get if you kill him. Good luck!");
                    Console.WriteLine();
                    PrintInTheMiddle(pressEnter);
                    Console.ReadKey();
                    Console.Clear();
                    //10% sannolikhet att inget händer
                    RandomChance();
                    Console.Clear();
                    SpecMonster.ShowGiantWurm();
                    break;
            }

            PrintInTheMiddle("Uh oh! A " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " appeared!");
            //Fight with monster
            while (Program.MyPlayer.Hp > 0 && SpecMonster.listOfMonsters[Program.MyPlayer.Level-1].Hp>0)
            {
                Random random = new Random();
                int myAttack = random.Next(Program.MyPlayer.Strength, Program.MyPlayer.Strength * 2) - SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Toughness;
                int monsterAttack = random.Next(SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Strength, SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Strength * 2)-Program.MyPlayer.Toughness;
                string s10 = "You hit the " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + ", dealing " + myAttack + " damage";
                SpecMonster.listOfMonsters[Program.MyPlayer.Level-1].Hp -= myAttack;
                string s11 = "UuuuuuOoooooAaaaaahhhhhhhhhh *slurp*";
                string s12 = "The " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " hit you, dealing " + monsterAttack + " damage";
                Program.MyPlayer.Hp -= monsterAttack;
                if (Program.MyPlayer.Hp < 0) { Program.MyPlayer.Hp = 0; }
                if (SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Hp < 0) { SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Hp = 0; }
                string s13 = $"{Program.playerName}: {Program.MyPlayer.Hp} hp";
                string s14 = $"{SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name}: {SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Hp} hp";
                PrintInTheMiddle(s10);
                PrintInTheMiddle(s11);
                PrintInTheMiddle(s12);
                PrintInTheMiddle(s13);
                PrintInTheMiddle(s14);
                PrintInTheMiddle("***********************************");
                PrintInTheMiddle(pressEnter);
                Console.ReadKey();
                Console.WriteLine();
            }
            if (Program.MyPlayer.Hp == 0)
            {
                PrintInTheMiddle("You were killed by the " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " :(");
                Console.WriteLine();
                Console.WriteLine();
                ShowGameOver();
                Console.WriteLine();
                PrintInTheMiddle(pressEnter);
                Console.ReadKey();
                
                Console.SetCursorPosition((Console.WindowWidth - "Would you like to try again? (y/n):  ".Length)/2,Console.CursorTop);
                Console.Write("Would you like to try again? (y/n): ");
                string ans = Console.ReadLine();
                if (ans == "y")
                {
                    Program.keepPlaing = false;
                    Program.choise = 1;
                    Console.Clear();
                }
                else
                {
                    Program.keepPlaing = false;
                    Program.choise = 4;

                }
            }
            else
            {
                GainTheProfit();
                Program.Menu();
            }

        }

        public static void ShowMervin()
        {
            PrintInTheMiddle("                          ,---.");
            PrintInTheMiddle("                         /    |");
            PrintInTheMiddle("                        /     |");
            PrintInTheMiddle("                       /      |");
            PrintInTheMiddle("                      /       |");
            PrintInTheMiddle("                 ___,'        |");
            PrintInTheMiddle("               <  -'          :");
            PrintInTheMiddle("                `-.__..--'``-,_\\_");
            PrintInTheMiddle("                   |o/ <o>` :,.)_`>");
            PrintInTheMiddle("                   :/ `     ||/)");
            PrintInTheMiddle("                   (_.).__,-` |\\");
            PrintInTheMiddle("                   /( `.``   `| :");
            PrintInTheMiddle("                   \'`-.)  `  ; ;");
            PrintInTheMiddle("                   | `       /-<");
            PrintInTheMiddle("                   |     `  /   `.");
            PrintInTheMiddle("   ,-_-..____     /|  `    :__..-'\\");
            PrintInTheMiddle("  /,'-.__\\\\  ``-./ :`      ;       \\");
            PrintInTheMiddle("  `\\ `\\  `\\  \\ :  (   `  /  ,   `.  \\");
            PrintInTheMiddle("    \\` \\   \\\\   |  | `   :  :     .\\ \\");
            PrintInTheMiddle("     \\ `\\_  ))  :  ;     |  |      ): :");
            PrintInTheMiddle("    (`-.-'\\ ||  |\\ \\   ` ;  ;       | |");
            PrintInTheMiddle("     \\-_   `;;._   ( `  /  /_       | |");
            PrintInTheMiddle("      `-.-.// ,'`-._\\__/_,'         ; |");
            
        }

        public static void RandomChance()
        {
            Random random = new Random();
            int random_int_pick = random.Next(0, 10);
            string s3 = "You see nothing but swaying grass all around you ...";
            string s4 = "You are soooo brave " + Program.playerName + ". You are lucky today and get 5 strength and 5 toughness!!!";
            if (random_int_pick == 1)
            {
                Console.SetCursorPosition((Console.WindowWidth - s3.Length) / 2, Console.CursorTop);
                Console.WriteLine(s3);
                Console.SetCursorPosition((Console.WindowWidth - pressEnter.Length) / 2, Console.CursorTop);
                Console.WriteLine(pressEnter);
                Console.ReadKey();
                Console.SetCursorPosition((Console.WindowWidth - s4.Length) / 2, Console.CursorTop);
                Console.WriteLine(s4);
                Console.SetCursorPosition((Console.WindowWidth - pressEnter.Length) / 2, Console.CursorTop);
                Console.WriteLine(pressEnter);
                Console.ReadKey();
                Program.MyPlayer.Toughness += 5;
                Program.MyPlayer.Strength += 5;
                Program.ShowDetails();

            }
        }
        public static void GainTheProfit()
        {
            Console.Clear();
            PrintInTheMiddle("CONGRATULATIONS !!!");
            Console.WriteLine();
            PrintInTheMiddle("You kill the " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " and gain " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].GoldToPlayer + " gold and " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].ExpToPlayer + " experience");
            Program.MyPlayer.Gold += SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].GoldToPlayer;
            Program.MyPlayer.Exp += +SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].ExpToPlayer;
            Program.MyPlayer.Level++;
            Console.WriteLine();
            Program.ShowDetails();
        }
        public static void ShowGameOver()
        {
            PrintInTheMiddle("        GGGGGGGGGGGGG                                                                        OOOOOOOOO                                                                   ");
            PrintInTheMiddle("     GGG::::::::::::G                                                                      OO:::::::::OO                                                                 ");
            PrintInTheMiddle("   GG:::::::::::::::G                                                                    OO:::::::::::::OO                                                               ");
            PrintInTheMiddle("   GG:::::::::::::::G                                                                    OO:::::::::::::OO                                                               ");
            PrintInTheMiddle(" G:::::G       GGGGGG  aaaaaaaaaaaaa      mmmmmmm    mmmmmmm       eeeeeeeeeeee         O::::::O   O::::::Ovvvvvvv           vvvvvvv eeeeeeeeeeee    rrrrr   rrrrrrrrr   ");
            PrintInTheMiddle("G:::::G                a::::::::::::a   mm:::::::m  m:::::::mm   ee::::::::::::ee       O:::::O     O:::::O v:::::v         v:::::vee::::::::::::ee  r::::rrr:::::::::r  ");
            PrintInTheMiddle("G:::::G                aaaaaaaaa:::::a m::::::::::mm::::::::::m e::::::eeeee:::::ee     O:::::O     O:::::O  v:::::v       v:::::ve::::::eeeee:::::eer:::::::::::::::::r ");
            PrintInTheMiddle("G:::::G    GGGGGGGGGG           a::::a m::::::::::::::::::::::me::::::e     e:::::e     O:::::O     O:::::O   v:::::v     v:::::ve::::::e     e:::::err::::::rrrrr::::::r");
            PrintInTheMiddle("G:::::G    G::::::::G    aaaaaaa:::::a m:::::mmm::::::mmm:::::me:::::::eeeee::::::e     O:::::O     O:::::O    v:::::v   v:::::v e:::::::eeeee::::::e r:::::r     r:::::r");
            PrintInTheMiddle("G:::::G    GGGGG::::G  aa::::::::::::a m::::m   m::::m   m::::me:::::::::::::::::e      O:::::O     O:::::O     v:::::v v:::::v  e:::::::::::::::::e  r:::::r     rrrrrrr");
            PrintInTheMiddle("G:::::G        G::::G a::::aaaa::::::a m::::m   m::::m   m::::me::::::eeeeeeeeeee       O:::::O     O:::::O      v:::::v:::::v   e::::::eeeeeeeeeee   r:::::r            ");
            PrintInTheMiddle(" G:::::G       G::::Ga::::a    a:::::a m::::m   m::::m   m::::me:::::::e                O::::::O   O::::::O       v:::::::::v    e:::::::e            r:::::r            ");
            PrintInTheMiddle("  G:::::GGGGGGGG::::Ga::::a    a:::::a m::::m   m::::m   m::::me::::::::e               O:::::::OOO:::::::O        v:::::::v     e::::::::e           r:::::r            ");
            PrintInTheMiddle("   GG:::::::::::::::Ga:::::aaaa::::::a m::::m   m::::m   m::::m e::::::::eeeeeeee        OO:::::::::::::OO          v:::::v       e::::::::eeeeeeee   r:::::r            ");
            PrintInTheMiddle("     GGG::::::GGG:::G a::::::::::aa:::am::::m   m::::m   m::::m  ee:::::::::::::e          OO:::::::::OO             v:::v         ee:::::::::::::e   r:::::r            ");
            PrintInTheMiddle("        GGGGGG   GGGG  aaaaaaaaaa  aaaammmmmm   mmmmmm   mmmmmm    eeeeeeeeeeeeee            OOOOOOOOO                vvv            eeeeeeeeeeeeee   rrrrrrr            ");
        }

    }
}
