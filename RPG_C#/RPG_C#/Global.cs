using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_C_
{
    internal class Global
    {
        //public Monster(int CurrentHp, int MaxHp, int Attack, int MaxDefense, int CurrentDefense)
        public static Heros heros = new Heros(90, 100, 20, 13, 12);
        public static Monster monster = new Monster(90, 100, 20, 13, 12);
    }
}
