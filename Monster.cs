using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Labb3VG
{
    class Monster
    {
        public static void ShowMonster()
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

        private string name;
        private int hp;

        public virtual void ShowMonsterDetails()
        {
            Console.WriteLine($"Monster: {this.name}");
            Console.WriteLine($"Health points: {this.hp}");
        }

        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
    
    }

}
