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
            Levels.PrintInTheMiddle("                                              ,--,  ,.-.            ");
            Levels.PrintInTheMiddle("                 ,                   \\,       '-,-`,'-.'| ._      ");
            Levels.PrintInTheMiddle("               /|           \\    ,   |\\         }  )/  / `-,',    ");
            Levels.PrintInTheMiddle("               [ '          |\\  /|   | |        /  \\|  |/`  ,`    ");
            Levels.PrintInTheMiddle("                | |       ,.`  `,` `, | |  _,...(   (      _',      ");
            Levels.PrintInTheMiddle("               \\  \\  __ ,-` `  ,  , `/ |,'      Y     (   \\_L\\  ");
            Levels.PrintInTheMiddle("                \\  \\_\\,``,   ` , ,  /  |         )         _,/   ");
            Levels.PrintInTheMiddle("                 \\  '  `  ,_ _`_,-,<._.<        /         /        ");
            Levels.PrintInTheMiddle("                  ', `>.,`  `  `   ,., |_      |         /          ");
            Levels.PrintInTheMiddle("                    \\/`  `,   `   ,`  | /__,.-`    _,   `\\        ");
            Levels.PrintInTheMiddle("                -,-..\\  _  \\  `  /  ,  / `._) _,-\\`       \\     ");
            Levels.PrintInTheMiddle("                 \\_,,.) /\\    ` /  / ) (-,, ``    ,        |      ");
            Levels.PrintInTheMiddle("                ,` )  | \\_\\       '-`  |  `(               \\     ");
            Levels.PrintInTheMiddle("               /  /```(   , --, ,' \\   |`<`    ,            |      ");
            Levels.PrintInTheMiddle("              /  /_,--`\\   <\\  V /> ,` )<_/)  | \\      _____)    ");
            Levels.PrintInTheMiddle("        ,-, ,`   `   (_,\\ \\    |   /) / __/  /   `----`           ");
            Levels.PrintInTheMiddle("       (-, \\           ) \\ ('_.-._)/ /,`    /                     ");
            Levels.PrintInTheMiddle("       | /  `          `/ \\ V   V, /`     /                        ");
            Levels.PrintInTheMiddle("    ,--\\(        ,     <_/`\\     ||      /                        ");
            Levels.PrintInTheMiddle("   (   ,``-     \\/|         \\-A.A-`|     /                        ");
            Levels.PrintInTheMiddle("  ,>,_ )_,..(    )\\          -,,_-`  _--`                          ");
            Levels.PrintInTheMiddle(" (_ \\|`   _,/_  /  \\_            ,--`                             ");
            Levels.PrintInTheMiddle("  \\( `   <.,../`     `-.._   _,-`                                  ");
            Levels.PrintInTheMiddle("   `                      ```                                       ");

        }

        public static void ShowGiantWurm()
        {
            Levels.PrintInTheMiddle("            _......._               ");
            Levels.PrintInTheMiddle("        .-'.'.'.'.'.'.`-.           ");
            Levels.PrintInTheMiddle("     /.'.'               '.\\       ");
            Levels.PrintInTheMiddle("     |.'    _.--...--._     |       ");
            Levels.PrintInTheMiddle("     \\    `._.-.....-._.'   /      ");
            Levels.PrintInTheMiddle("     |     _..- .-. -.._   |        ");
            Levels.PrintInTheMiddle("  .-.'    `.   ((@))  .'   '.-.     ");
            Levels.PrintInTheMiddle(" ( ^ \\      `--.   .-'     / ^ )   ");
            Levels.PrintInTheMiddle(" \\  /          .   .       \\  /   ");
            Levels.PrintInTheMiddle("  /          .'     '.  .-     \\   ");
            Levels.PrintInTheMiddle(" ( _.\\    \\ (_`-._.-'_)   /._\\)  ");
            Levels.PrintInTheMiddle("  `-' \\   ' .--.          / `-'    ");
            Levels.PrintInTheMiddle("      |  / /|_| `-._.'\\   |        ");
            Levels.PrintInTheMiddle("      |   |       |_| |   /-.._     ");
            Levels.PrintInTheMiddle("  _..-\\   `.--.______.'  |         ");
            Levels.PrintInTheMiddle("       \\       .....     |         ");
            Levels.PrintInTheMiddle("        `.  .'      `.  /           ");
            Levels.PrintInTheMiddle("          \\           .'           ");
            Levels.PrintInTheMiddle("           `-..___..-`              ");
            Console.WriteLine();

        }

        public static void ShowChupacabra()
        {
            Levels.PrintInTheMiddle("      /^\\      /^\\                   ");
            Levels.PrintInTheMiddle("      |  \\    /  |                    ");
            Levels.PrintInTheMiddle("      ||\\ \\../ /||                   ");
            Levels.PrintInTheMiddle("      )'        `(                     ");
            Levels.PrintInTheMiddle("     ,;`w,    ,w';,                    ");
            Levels.PrintInTheMiddle("     ;,  ) __ (  ,;                    ");
            Levels.PrintInTheMiddle("      ;  \\(\\/)/  ;;                  ");
            Levels.PrintInTheMiddle("     ;|  |vwwv|    ``-...              ");
            Levels.PrintInTheMiddle("      ;  `lwwl'   ;      ```''-.       ");
            Levels.PrintInTheMiddle("     ;| ; `''' ; ;              \\.    ");
            Levels.PrintInTheMiddle("      ;         ,   ,          , |     ");
            Levels.PrintInTheMiddle("      '  ;      ;   l    .     | |     ");
            Levels.PrintInTheMiddle("      ;    ,  ,    |,-,._|      \\;    ");
            Levels.PrintInTheMiddle("       ;  ; `' ;   '    \\ `\\     \\; ");
            Levels.PrintInTheMiddle("       |  |    |  |     |   |    |;    ");
            Levels.PrintInTheMiddle("       |  ;    ;  |      \\   \\   (;  ");
            Levels.PrintInTheMiddle("       | |      | l       | | \\  |    ");
            Levels.PrintInTheMiddle("       | |      | |       | |  ) |     ");
            Levels.PrintInTheMiddle("       | |      | ;       | |  | |     ");
            Levels.PrintInTheMiddle("       ; ,      : ,      ,_.'  | |     ");
            Levels.PrintInTheMiddle("      :__'      | |           ,_.'     ");
            Levels.PrintInTheMiddle("               `--'                    ");
        }
        public static void ShowDracula()
        {
            Levels.PrintInTheMiddle("");
            Levels.PrintInTheMiddle("                 /######\\                 ");
            Levels.PrintInTheMiddle("               /##########\\               ");
            Levels.PrintInTheMiddle("              /   \\###/    \\             ");
            Levels.PrintInTheMiddle("             /     \\#/      \\            ");
            Levels.PrintInTheMiddle("          /\\|               |/\\          ");
            Levels.PrintInTheMiddle("          | | \\ ==\\    /== / | |         ");
            Levels.PrintInTheMiddle("           \\|  \\<|>\\  /<|>/  |/     /|   ");
            Levels.PrintInTheMiddle("    \\__     |    -   \\  -    |     /#|    ");
            Levels.PrintInTheMiddle("     \\#\\     |        |      |   /###|   ");
            Levels.PrintInTheMiddle("      \\##\\   |       \\|     |  /#####|    ");
            Levels.PrintInTheMiddle("       \\###\\  |   _______  | /######|     ");
            Levels.PrintInTheMiddle("        \\####\\ | / \\/ \\/ \\|/#######|      ");
            Levels.PrintInTheMiddle("        |######\\|        |#########|      ");
            Levels.PrintInTheMiddle("        |########\\______/##########|      ");
            Levels.PrintInTheMiddle("        |#########\\    /##########/       ");
            Levels.PrintInTheMiddle("        |##########\\  |#########/\\       ");
            Levels.PrintInTheMiddle("        /###########\\/########/###\\      ");
            Levels.PrintInTheMiddle("    /################\\######/########\\   ");
            Levels.PrintInTheMiddle("   /##################\\###/###########\\  ");
            Levels.PrintInTheMiddle("  /###################\\#/##############\\ ");
            Levels.PrintInTheMiddle(" /####################/#################\\ ");
            Levels.PrintInTheMiddle("/###################/####################\\");
            Levels.PrintInTheMiddle("");
        }

    }
}
