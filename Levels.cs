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
        public static void Level()
        {
           Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (Program.MyPlayer.Level < 11)
            {
                PrintInTheMiddle("Level " + Program.MyPlayer.Level);
            }

            switch (Program.MyPlayer.Level)
            {
                case 1:
                    ShowFOREST();
                    MoveToNext();
                    ShowMervin();
                    PrintInTheMiddle("Hi " + Program.playerName + ". I'm Mervin and I know everything about this forest. There is a Giant Wurm in the forest");
                    PrintInTheMiddle("thats why you have to be carefull. The Giant Wurm have some gold you can get if you kill him. Good luck!");
                    Console.WriteLine();
                    PrintInTheMiddle(pressEnter);
                    Console.ReadKey();
                    Console.Clear();
                    //10% sannolikhet att inget händer
                    RandomChance();
                    SpecMonster.ShowGiantWurm();
                    Console.WriteLine();
                    Fight();
                    break;
                case 2:
                    ShowMOUNTAIN();
                    MoveToNext();
                    RandomChance();
                    do
                    {
                        ShowMervin();
                        PrintInTheMiddle("Wow " + Program.MyPlayer.Name + ", that was a great fight with the " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 2].Name + ".");
                        PrintInTheMiddle("You killed him and took his gold. I advise you to go to the shop because this time you will meet ");
                        PrintInTheMiddle("the " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " - the king of this Mountain. Good luck!");
                        Console.WriteLine();
                        Program.ShowMeny();
                        switch (Program.choise)
                        {
                            case 2:
                                Program.ShowDetails();
                                break;
                            case 3:
                                Shoping.Shoping1();
                                break;
                        }
                    } while (Program.choise == 2 || Program.choise == 3);

                    if (Program.choise == 1)
                    {
                        Console.Clear();
                        SpecMonster.ShowDragon();
                        Console.WriteLine();

                        PrintInTheMiddle("Uh oh! A " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " appeared!");
                        //Fight with monster until the monster or player win
                        Fight();
                    }
                    else Program.keepPlaing = false;
                    break;
                case 3:
                    ShowJUNGLE();
                    MoveToNext();
                    RandomChance();
                    do
                    {
                        ShowMervin();
                        PrintInTheMiddle("Wow " + Program.MyPlayer.Name + ", that was a great fight with the " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 2].Name + ".");
                        PrintInTheMiddle("You killed him and took his gold. I advise you to go to the shop because this time you will meet ");
                        PrintInTheMiddle("the " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " - the king of this Mountain. Good luck!");
                        Console.WriteLine();
                        Program.ShowMeny();
                        switch (Program.choise)
                        {
                            case 2:
                                Program.ShowDetails();
                                break;
                            case 3:
                                Shoping.Shoping1();
                                break;
                        }
                    } while (Program.choise == 2 || Program.choise == 3);

                    if (Program.choise == 1)
                    {
                        Console.Clear();
                        SpecMonster.ShowChupacabra();
                        Console.WriteLine();

                        PrintInTheMiddle("Uh oh! A " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " appeared!");
                        //Fight with monster until the monster or player win
                        Fight();
                    }
                    break;
                case 4:
                    ShowCASTLE();
                    MoveToNext();
                    RandomChance();
                    do
                    {
                        ShowMervin();
                        PrintInTheMiddle("Wow " + Program.MyPlayer.Name + ", that was a great fight with " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 2].Name + ".");
                        PrintInTheMiddle("You killed him and took his gold. I advise you to go to the shop because this time you will meet ");
                        PrintInTheMiddle(" " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " - the Lord of this Castle. Good luck!");
                        Console.WriteLine();
                        Program.ShowMeny();
                        switch (Program.choise)
                        {
                            case 2:
                                Program.ShowDetails();
                                break;
                            case 3:
                                Shoping.Shoping1();
                                break;
                        }
                    } while (Program.choise == 2 || Program.choise == 3);

                    if (Program.choise == 1)
                    {
                        Console.Clear();
                        SpecMonster.ShowDracula();
                        Console.WriteLine();

                        PrintInTheMiddle("Uh oh! A " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " appeared!");
                        //Fight with monster until the monster or player win
                        Fight();
                    }
                    break;
                case 5:
                    RandomChance();
                    Fight();
                    break;
                case 6:
                    RandomChance();
                    Fight();
                    break;
                case 7:
                    RandomChance();
                    Fight();
                    break;
                case 8:
                    RandomChance();
                    Fight();
                    break;
                case 9:
                    RandomChance();
                    Fight();
                    break;
                case 10:
                    RandomChance();
                    Fight();
                    break;
                default:
                PrintInTheMiddle("YOU WON THE GAME !!!");
                    Program.keepPlaing = false;
                break;
            }
            


        }

        public static void Fight()
        {
            while (Program.MyPlayer.Hp > 0 && SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Hp > 0)
            {
                Random random = new Random();
                int myAttack = random.Next(Program.MyPlayer.Strength, Program.MyPlayer.Strength * 2) - SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Toughness;
                int monsterAttack = random.Next(SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Strength, SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Strength * 2) - Program.MyPlayer.Toughness;

                SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Hp -= myAttack;

                Program.MyPlayer.Hp -= monsterAttack;
                if (Program.MyPlayer.Hp < 0) { Program.MyPlayer.Hp = 0; }
                if (SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Hp < 0) { SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Hp = 0; }

                PrintInTheMiddle("You hit the " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + ", dealing " + myAttack + " damage");
                PrintInTheMiddle("UuuuuuOoooooAaaaaahhhhhhhhhh *slurp*");
                PrintInTheMiddle("The " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " hit you, dealing " + monsterAttack + " damage");
                PrintInTheMiddle($"{Program.playerName}: {Program.MyPlayer.Hp} hp");
                PrintInTheMiddle($"{SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name}: {SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Hp} hp");
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

                Console.SetCursorPosition((Console.WindowWidth - "Would you like to try again? (y/n):  ".Length) / 2, Console.CursorTop);
                Console.Write("Would you like to try again? (y/n): ");
                string ans = Console.ReadLine();
                // if player wouldlike to play again
                if (ans == "y")
                {
                    Program.keepPlaing = false;
                    Program.choise = 1;
                    Console.Clear();
                }
                else // player choise to close the game
                {
                    Program.keepPlaing = false;
                    Program.choise = 4;

                }
            }
            else
            {
                GainTheProfit();
            }
        }

        private static void MoveToNext()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            PrintInTheMiddle(pressEnter);
            Console.ReadKey();
            Console.Clear();
        }

        public static void ShowFOREST()
        {
            PrintInTheMiddle("    _______  _______  _______  _______  _______ _________   ");
            PrintInTheMiddle("(  ____ \\(  ___  )(  ____ )(  ____ \\(  ____ \\__   __/ ");
            PrintInTheMiddle("| (    \\/| (   ) || (    )|| (    \\/| (    \\/   ) (   ");
            PrintInTheMiddle("    | (__    | |   | || (____)|| (__    | (_____    | |      ");
            PrintInTheMiddle("    |  __)   | |   | ||     __)|  __)   (_____  )   | |      ");
            PrintInTheMiddle("  | (      | |   | || (\\ (   | (            ) |   | |     ");
            PrintInTheMiddle("| )      | (___) || ) \\ \\__| (____/\\/\\____) |   | |  ");
            PrintInTheMiddle("  |/       (_______)|/   \\__/(_______/\\_______)   )_(    ");
        }

        public static void ShowMOUNTAIN()
        {
            PrintInTheMiddle("    _______  _______           _       _________ _______ _________ _          ");
            PrintInTheMiddle("(       )(  ___  )|\\     /|( (    /|\\__   __/(  ___  )\\__   __/( (    /|");
            PrintInTheMiddle(" | () () || (   ) || )   ( ||  \\  ( |   ) (   | (   ) |   ) (   |  \\  ( | ");
            PrintInTheMiddle("  | || || || |   | || |   | ||   \\ | |   | |   | (___) |   | |   |   \\ | |  ");
            PrintInTheMiddle("| |(_)| || |   | || |   | || (\\ \\) |   | |   |  ___  |   | |   | (\\ \\) |");
            PrintInTheMiddle("| |   | || |   | || |   | || | \\   |   | |   | (   ) |   | |   | | \\   |");
            PrintInTheMiddle("| )   ( || (___) || (___) || )  \\  |   | |   | )   ( |___) (___| )  \\  |");
            PrintInTheMiddle("|/     \\|(_______)(_______)|/    )_)   )_(   |/     \\|\\_______/|/    )_)");
        }

        public static void ShowJUNGLE()
        {
            PrintInTheMiddle("      _ _   _ _   _  ____ _     _____ ");
            PrintInTheMiddle("     | | | | | \\ | |/ ___| |   | ____|");
            PrintInTheMiddle("  _  | | | | |  \\| | |  _| |   |  _|  ");
            PrintInTheMiddle(" | |_| | |_| | |\\  | |_| | |___| |___ ");
            PrintInTheMiddle("  \\___/ \\___/|_| \\_|\\____|_____|_____|");
            PrintInTheMiddle("");
            PrintInTheMiddle("");
        }
        public static void ShowCASTLE()
        {
            Levels.PrintInTheMiddle(" _______  _______  _______ _________ _        _______     ");
            Levels.PrintInTheMiddle("(  ____ \\(  ___  )(  ____ \\\\__   __/( \\      (  ____ \\   ");
            Levels.PrintInTheMiddle("| (    \\/| (   ) || (    \\/   ) (   | (      | (    \\/    ");
            Levels.PrintInTheMiddle("| |      | (___) || (_____    | |   | |      | (__        ");
            Levels.PrintInTheMiddle("| |      |  ___  |(_____  )   | |   | |      |  __)       ");
            Levels.PrintInTheMiddle("| |      | (   ) |      ) |   | |   | |      | (          ");
            Levels.PrintInTheMiddle("| (____/\\| )   ( |/\\____) |   | |   | (____/\\| (____/\\    ");
            Levels.PrintInTheMiddle("(_______/|/     \\|\\_______)   )_(   (_______/(_______/    ");
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
            Console.WriteLine();
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
            PrintInTheMiddle("You kill the " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].Name + " and gain " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].GoldToPlayer + " gold, " + SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].ExpToPlayer + " experience, " + Program.MyPlayer.Level*2 + " strength and " + Program.MyPlayer.Level * 2 + " toughness");
            Program.MyPlayer.Gold += SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].GoldToPlayer;
            Program.MyPlayer.Exp += +SpecMonster.listOfMonsters[Program.MyPlayer.Level - 1].ExpToPlayer;
            Program.MyPlayer.Strength += Program.MyPlayer.Level * 2;
            Program.MyPlayer.Toughness += Program.MyPlayer.Level * 2;
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
