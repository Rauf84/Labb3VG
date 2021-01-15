using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG
{
    class SpecMonster : Monster
    {
        public static List<SpecMonster> listOfMonsters = new List<SpecMonster>();
 
        int strength;
        int toughness;

        public int Strength { get => strength; set => strength = value; }
        public int Toughness { get => toughness; set => toughness = value; }

        public SpecMonster (string name, int hp, int goldToPlayer, int expToPlayer, int strength, int Toughness)
        {
            this.Name = name;
            this.Hp = hp;
            this.GoldToPlayer = goldToPlayer;
            this.ExpToPlayer = expToPlayer;
            this.strength = strength;
            this.toughness = Toughness;
        }

        public static void AddMonster()
        {
            listOfMonsters.Add(new SpecMonster("Giant Wurm",100, 10, 35, 8, 1));
            listOfMonsters.Add(new SpecMonster("Flying Dragon", 100, 18, 35, 12, 5));
            listOfMonsters.Add(new SpecMonster("Chupacabra", 100, 22, 35, 17, 8));
            listOfMonsters.Add(new SpecMonster("Dracula", 100, 30, 35, 23, 12));
            listOfMonsters.Add(new SpecMonster("Frankenstein", 100, 40, 35, 29, 17));
            listOfMonsters.Add(new SpecMonster("Pirate Ghost", 100, 52, 35, 36, 24));
            listOfMonsters.Add(new SpecMonster("Freddie Krueger", 100, 66, 35, 44, 28));
            listOfMonsters.Add(new SpecMonster("Lucifer", 100, 80, 35, 53, 32));
            listOfMonsters.Add(new SpecMonster("Zombie", 100, 100, 35, 63, 38));
            listOfMonsters.Add(new SpecMonster("Long Tooth", 100, 125, 35, 74, 44));
        }
        
        public static void ShowDragon()
        {
            Console.WriteLine("                                              ,--,  ,.-.");
            Console.WriteLine("                ,                   \\,       '-,-`,'-.' | ._");
            Console.WriteLine("               /|           \\    ,   |\\         }  )/  / `-,',");
            Console.WriteLine("               [ '          |\\  /|   | |        /  \\|  |/`  ,`");
            Console.WriteLine("               | |       ,.`  `,` `, | |  _,...(   (      _',");
            Console.WriteLine("               \\  \\  __ ,-` `  ,  , `/ |,'      Y     (   \\_L\\");
            Console.WriteLine("                \\  \\_\\,``,   ` , ,  /  |         )         _,/");
            Console.WriteLine("                 \\  '  `  ,_ _`_,-,<._.<        /         /");
            Console.WriteLine("                  ', `>.,`  `  `   ,., |_      |         /");
            Console.WriteLine("                    \\/`  `,   `   ,`  | /__,.-`    _,   `\\");
            Console.WriteLine("                -,-..\\  _  \\  `  /  ,  / `._) _,-\\`       \\");
            Console.WriteLine("                 \\_,,.) /\\    ` /  / ) (-,, ``    ,        |");
            Console.WriteLine("                ,` )  | \\_\\       '-`  |  `(               \\");
            Console.WriteLine("               /  /```(   , --, ,' \\   |`<`    ,            |");
            Console.WriteLine("              /  /_,--`\\   <\\  V /> ,` )<_/)  | \\      _____)");
            Console.WriteLine("        ,-, ,`   `   (_,\\ \\    |   /) / __/  /   `----`");
            Console.WriteLine("       (-, \\           ) \\ ('_.-._)/ /,`    /");
            Console.WriteLine("       | /  `          `/ \\ V   V, /`     /");
            Console.WriteLine("    ,--\\(        ,     <_/`\\     ||      /");
            Console.WriteLine("   (   ,``-     \\/|         \\-A.A-`|     /");
            Console.WriteLine("  ,>,_ )_,..(    )\\          -,,_-`  _--`");
            Console.WriteLine(" (_ \\|`   _,/_  /  \\_            ,--`");
            Console.WriteLine("  \\( `   <.,../`     `-.._   _,-`");
            Console.WriteLine("   `                      ```");

        }

        public static void ShowGiantWurm()
        {
            string s1 = "            _......._";
            string s2 ="            _......._";
            string s3="        .-'.'.'.'.'.'.`-.";
            string s4="     /.'.'               '.\\";
            string s5= "     |.'    _.--...--._     |";
            string s6="     \\    `._.-.....-._.'   /";
            string s7="     |     _..- .-. -.._   |";
            string s8="  .-.'    `.   ((@))  .'   '.-.";
            string s9 = " ( ^ \\      `--.   .-'     / ^ )";
            string s10 = "  \\  /         .   .       \\  /";
            string s11 = "  /          .'     '.  .-    \\";
            string s12 = " ( _.\\    \\ (_`-._.-'_)    /._\\)";
            string s13="  `-' \\   ' .--.          / `-'";
            string s14="      |  / /|_| `-._.'\\   |";
            string s15="      |   |       |_| |   /-.._";
            string s16="  _..-\\   `.--.______.'  |";
            string s17="       \\       .....     |";
            string s18="        `.  .'      `.  /";
            string s19="          \\           .'";
            string s20="           `-..___..-`";

            Levels.PrintInTheMiddle(s1);
            Levels.PrintInTheMiddle(s2);
            Levels.PrintInTheMiddle(s3);
            Levels.PrintInTheMiddle(s4);
            Levels.PrintInTheMiddle(s5);
            Levels.PrintInTheMiddle(s6);
            Levels.PrintInTheMiddle(s7);
            Levels.PrintInTheMiddle(s8);
            Levels.PrintInTheMiddle(s9);
            Levels.PrintInTheMiddle(s10);
            Levels.PrintInTheMiddle(s11);
            Levels.PrintInTheMiddle(s12);
            Levels.PrintInTheMiddle(s13);
            Levels.PrintInTheMiddle(s14);
            Levels.PrintInTheMiddle(s15);
            Levels.PrintInTheMiddle(s16);
            Levels.PrintInTheMiddle(s17);
            Levels.PrintInTheMiddle(s18);
            Levels.PrintInTheMiddle(s19);
            Levels.PrintInTheMiddle(s20);

        }

    }
}
