using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Labb3VG
{
    abstract class Monster // en basklass som ärv av SpecMonster
    {

        private string name;
        private int hp;
        private int goldToPlayer;
        private int expToPlayer;

        public virtual void ShowMonsterDetails() // används inte i spelet, har används för att testa värden 
        {
            Console.WriteLine($"Monster: {this.name}");
            Console.WriteLine($"Health points: {this.hp}");
            Console.WriteLine($"Gold : { this.goldToPlayer}");
        }

        public int GoldToPlayer { get => goldToPlayer; set => goldToPlayer = value; }
        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public int ExpToPlayer { get => expToPlayer; set=>expToPlayer = value; }
    
    }

}
