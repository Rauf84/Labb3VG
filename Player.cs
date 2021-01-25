using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG
{
    class Player // struktur för en spelare spm deklareras i Program.cs i under MyPlayer metoden
    {
        private int hp;
        private int exp;
        private int gold;
        private int level;
        private int avatar;
        private string name;
        private int strength;
        private int toughness;

        public Player(string name, int avatar, int hp, int exp, int gold, int level, int strength, int toughness)
        {
            this.hp = hp;
            this.exp = exp;
            this.gold = gold;
            this.name = name;
            this.level = level;
            this.avatar = avatar;
            this.strength = strength;
            this.toughness = toughness;
        }
        public int Hp { get => hp; set => hp = value; }
        public int Exp { get => exp; set => exp = value; }
        public int Gold { get => gold; set => gold = value; }
        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Avatar { get => avatar; set => avatar = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Toughness { get => toughness; set => toughness = value; }
    }
}
