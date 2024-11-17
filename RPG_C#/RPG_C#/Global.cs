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
        //public static Heros heros = new Heros(90, 100, 20, 13, 12);
        public static Player player = new Player(90, 100, 20, 13, 12,6);
        //public static Ennemy ennemy = new Ennemy(90, 100, 20, 13, 12);

        //random stat ennemy
        public static Random rnd = new Random();
        public static int randomHp = rnd.Next(80, 100);
        public static int randomAttack = rnd.Next(15, 25);
        public static int randomDefense = rnd.Next(10, 15);
        public static Ennemy ennemy = new Ennemy(randomHp, randomHp, randomAttack, randomDefense, randomDefense);
    }
}
