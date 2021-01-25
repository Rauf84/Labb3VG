using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG
{
    class SpecMonster : Monster // arver struc från Monster och lägger till Strenght och toughness
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

        public static void AddMonster() // deklarerar 10  SpecMonstrar i en lista 
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
        
        // metoder som skriver ut unika bilder på monstrar 
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
        public static void ShowFrankenstein()
        {
            Levels.PrintInTheMiddle("                                         .....     ");
            Levels.PrintInTheMiddle("                                        C C  /     ");
            Levels.PrintInTheMiddle("                                       /<   /      ");
            Levels.PrintInTheMiddle("                        ___ __________/_#__=o      ");
            Levels.PrintInTheMiddle("                       /(- /(\\_\\________   \\        ");
            Levels.PrintInTheMiddle("                       \\ ) \\ )_      \\o     \\      ");
            Levels.PrintInTheMiddle("                       /|\\ /|\\       |'     |       ");
            Levels.PrintInTheMiddle("                                     |     _|      ");
            Levels.PrintInTheMiddle("                                     /o   __\\      ");
            Levels.PrintInTheMiddle("                                    / '     |      ");
            Levels.PrintInTheMiddle("                                   / /      |      ");
            Levels.PrintInTheMiddle("                                  /_/\\______|      ");
            Levels.PrintInTheMiddle("                                 (   _(    <       ");
            Levels.PrintInTheMiddle("                                  \\    \\    \\       ");
            Levels.PrintInTheMiddle("                                   \\    \\    |      ");
            Levels.PrintInTheMiddle("                                    \\____\\____\\     ");
            Levels.PrintInTheMiddle("                                  ____\\_\\__\\_\\     ");
            Levels.PrintInTheMiddle("                                 /`   /`     o\\       ");
            Levels.PrintInTheMiddle("                                 |___ |_______|.. .   ");
            Levels.PrintInTheMiddle("");
        }
        public static void ShowPirateGhost()
        {
            Levels.PrintInTheMiddle("         _,-._                                              ");
            Levels.PrintInTheMiddle("        ; ___ :           ,------------------------------.  ");
            Levels.PrintInTheMiddle("    ,--' (. .) '--.__    |                                | ");
            Levels.PrintInTheMiddle("  _;      |||        \\   |   Give me your gold, loser!    |");
            Levels.PrintInTheMiddle(" '._,-----''';=.____,'   |                                | ");
            Levels.PrintInTheMiddle("   /// < o>   |##|       |                                | ");
            Levels.PrintInTheMiddle("   (o        \\`--'       //`-----------------------------' ");
            Levels.PrintInTheMiddle("  ///\\ >>>>  _\\ <<<<    //                                 ");
            Levels.PrintInTheMiddle(" --._>>>>>>>><<<<<<<<  /                                    ");
            Levels.PrintInTheMiddle(" ___() >>>[||||]<<<<                                        ");
            Levels.PrintInTheMiddle(" `--'>>>>>>>><<<<<<<                                        ");
            Levels.PrintInTheMiddle("      >>>>>>><<<<<<                                         ");
            Levels.PrintInTheMiddle("        >>>>><<<<<                                          ");
            Levels.PrintInTheMiddle("         >>ctr<<                                            ");
        }
        public static void ShowFreddie()
        {
            Levels.PrintInTheMiddle("                             (                         ");
            Levels.PrintInTheMiddle("                .            )        )                ");
            Levels.PrintInTheMiddle("                         (  (|              .          ");
            Levels.PrintInTheMiddle("                     )   )\\/ ( ( (                     ");
            Levels.PrintInTheMiddle("             *  (   ((  /     ))\\))  (  )    )         ");
            Levels.PrintInTheMiddle("           (     \\   )\\(          |  ))( )  (|         ");
            Levels.PrintInTheMiddle("           >)     ))/   |          )/  \\((  ) \\        ");
            Levels.PrintInTheMiddle("           (     (      .        -.     V )/   )(    ( ");
            Levels.PrintInTheMiddle("            \\   /     .   \\            .       \\))   ))");
            Levels.PrintInTheMiddle("              )(      (  | |   )            .    (  /  ");
            Levels.PrintInTheMiddle("             )(    ,'))     \\ /          \\( `.    )    ");
            Levels.PrintInTheMiddle("             (\\>  ,'/__      ))            __`.  /     ");
            Levels.PrintInTheMiddle("            ( \\   | /  ___   ( \\/     ___   \\ | ( (    ");
            Levels.PrintInTheMiddle("             \\.)  |/  /   \\__      __/   \\   \\|  ))    ");
            Levels.PrintInTheMiddle("            .  \\. |>  \\      | __ |      /   <|  /     ");
            Levels.PrintInTheMiddle("                 )/    \\____/ :..: \\____/     \\ <      ");
            Levels.PrintInTheMiddle("          )   \\ (|__  .      / ;: \\          __| )  (  ");
            Levels.PrintInTheMiddle("         ((    )\\)  ~--_     --  --      _--~    /  )) ");
            Levels.PrintInTheMiddle("          \\    (    |  ||               ||  |   (  /   ");
            Levels.PrintInTheMiddle("                \\.  |  ||_             _||  |  /       ");
            Levels.PrintInTheMiddle("                  > :  |  ~V+-I_I_I-+V~  |  : (.       ");
            Levels.PrintInTheMiddle("                 (  \\:  T\\   _     _   /T  : ./        ");
            Levels.PrintInTheMiddle("                  \\  :    T^T T-+-T T^T    ;<          ");
            Levels.PrintInTheMiddle("                   \\..`_       -+-       _'  )         ");
            Levels.PrintInTheMiddle("                    \\_______________________/          ");
            Levels.PrintInTheMiddle("");
        }
        public static void ShowLucifer()
        {
            Levels.PrintInTheMiddle("                    `' -._                    ");
            Levels.PrintInTheMiddle("                      `. ' -._                ");
            Levels.PrintInTheMiddle("                        T.   ' -.             ");
            Levels.PrintInTheMiddle("                         $$p.   ' -.          ");
            Levels.PrintInTheMiddle("                         $$$$b.    `,        ");
            Levels.PrintInTheMiddle("                      .g$$$$$$$b    ;        ");
            Levels.PrintInTheMiddle("                    .d$$$$$$$$$$;   ;        ");
            Levels.PrintInTheMiddle("                 __d$$$$$$P''^T$$   :        ");
            Levels.PrintInTheMiddle("               .d$$$$P^^''___       :        ");
            Levels.PrintInTheMiddle("              d$P'__..gg$$$$$$$$$$; ;        ");
            Levels.PrintInTheMiddle("             d$$ :$$$$$$$$$$$$$$$$;  ;       ");
            Levels.PrintInTheMiddle("            :$$; $$$$$$$$$$$$$$$$P  :$       ");
            Levels.PrintInTheMiddle("            :$$; $$$$$$$$$$$$$$$$P  :$       ");
            Levels.PrintInTheMiddle("            $$$  $$$$$$$$$$$$$$$$b  $$       ");
            Levels.PrintInTheMiddle("           :$$$ :$$$$$$$$$$$$$$$$$; $$;      ");
            Levels.PrintInTheMiddle("           :$$$ :$$$$$$$$$$$$$$$$$; $$;      ");
            Levels.PrintInTheMiddle("           $$$; $$$$$$$$$$$$$$$$$$; $$;      ");
            Levels.PrintInTheMiddle("          :$$$  $$$$$$$$$^$$$$$$$$$ :$$      ");
            Levels.PrintInTheMiddle("          $$$; :$$$p__gP' `Tp__g$$$ :$$      ");
            Levels.PrintInTheMiddle("         :$$$  $$P`T$P' .$. `T$P'T$; $$;     ");
            Levels.PrintInTheMiddle("         $$$; :$$;     :P^T;     :$; $$;     ");
            Levels.PrintInTheMiddle("        :$$$  $$$$-.           .-$$$ :$$     ");
            Levels.PrintInTheMiddle("        $$$$ :$$$$; \\   T$P   / :$$$  $$     ");
            Levels.PrintInTheMiddle("       :$$$; $$$$$$  ; b:$;d :  $$$$; $$;    ");
            Levels.PrintInTheMiddle("       $$$$; $$$$$$; : T T T ; :$$$$$ :$$    ");
            Levels.PrintInTheMiddle("    .g$$$$$  :$$$$$$  ;' | ':  $$$$$$  T$b   ");
            Levels.PrintInTheMiddle(" .g$$$$$$$$   $$$$$$b :     ; d$$$$$;   `Tb  ");
            Levels.PrintInTheMiddle(":$$$$$$$$$;   :$$$$$$$;     :$$$$$$P       \\ ");
            Levels.PrintInTheMiddle(":$$$$$$$$$;    T$$$$$$$p._.g$$$$$$P         ;");
            Levels.PrintInTheMiddle("$$$P^^T$$$$p.   `T$$$$$$$$$$$$$$P'     _/`. :");
            Levels.PrintInTheMiddle("       `T$$$$$b.  `T$$$$$$$$$$P'    .g$P   \\;");
            Levels.PrintInTheMiddle("         `T$$$$$b.  ' ^ T$$$$P ^ '     d$P'      ");
            Levels.PrintInTheMiddle("           `T$$$$$b.             .dP'        ");
            Levels.PrintInTheMiddle("             ' ^ T$$$$b.        .g$P'          ");
            Console.WriteLine();
        }
        public static void ShowZombie()
        {
            Levels.PrintInTheMiddle("              .--._        ");
            Levels.PrintInTheMiddle("        __   '---._)       ");
            Levels.PrintInTheMiddle("      '')\\   Q Q )        ");
            Levels.PrintInTheMiddle("        =_/   c  /         ");
            Levels.PrintInTheMiddle("        | \\_.-;-'-,._     ");
            Levels.PrintInTheMiddle("        |  '  o---o   )    ");
            Levels.PrintInTheMiddle("         \\   /H __H\\/    ");
            Levels.PrintInTheMiddle("          '-' \\'')\\/|    ");
            Levels.PrintInTheMiddle("            _ |_='-)_/     ");
            Levels.PrintInTheMiddle("           /  '.    )      ");
            Levels.PrintInTheMiddle("          /         /      ");
            Levels.PrintInTheMiddle("         |___/\\|   /      ");
            Levels.PrintInTheMiddle("          |_|  |   |       ");
            Levels.PrintInTheMiddle("         /  )  \\   \\     ");
            Levels.PrintInTheMiddle("        (__/    \\___\\    ");
            Levels.PrintInTheMiddle("                  \\_\\    ");
            Levels.PrintInTheMiddle("                  /  )     ");
            Levels.PrintInTheMiddle("                 (__/      ");
            Levels.PrintInTheMiddle("");
        }
        public static void ShowLongTooth()
        {
            Levels.PrintInTheMiddle("    _                                                       ");
            Levels.PrintInTheMiddle("  ( \\                ..-----..__                          ");
            Levels.PrintInTheMiddle("   \\.'.        _.--'`  [   '  ' ```'-._                   ");
            Levels.PrintInTheMiddle("    `. `'-..-'' `    '  ' '   .  ;   ; `-'''-.,__/|/_      ");
            Levels.PrintInTheMiddle("      `'-.;..-''`|'  `.  '.    ;     '  `    '   `'  `,    ");
            Levels.PrintInTheMiddle("                 \\ '   .    ' .     '   ;   .`   . ' 7 \\ ");
            Levels.PrintInTheMiddle("                  '.' . '- . \\    .`   .`  .   .\\     `Y ");
            Levels.PrintInTheMiddle("                    '-.' .   ].  '   ,    '    /'`''';:'   ");
            Levels.PrintInTheMiddle("                      /Y   '.] '-._ /    ' _.-'            ");
            Levels.PrintInTheMiddle("                      \\'\\_   ; (`'.'.'  .'/                ");
            Levels.PrintInTheMiddle("                       ' )` /  `.'   .-'.'                 ");
            Levels.PrintInTheMiddle("                        '\\  \\).'  .-'--'                   ");
            Levels.PrintInTheMiddle("                          `. `,_'`                         ");
            Levels.PrintInTheMiddle("                            `.__)                          ");
        }


    }
}
