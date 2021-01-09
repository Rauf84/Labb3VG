using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG
{
    class SpecMonster : Monster
    {
        private int hp;
        private int strength;
        private int toughness;

        public int Hp1 { get => hp; set => hp = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Toughness { get => toughness; set => toughness = value; }
    }
}
