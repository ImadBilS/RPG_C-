using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_C_
{
    internal class Global
    {
        //public Monster(int CurrentHp, int MaxHp, int Attack, int Defense, int Shield)
        //public static Heros heros = new Heros(90, 100, 20, 13, 12);
        //public static Player player = new Player(90, 100, 20, 13, 12);

        //public static Ennemy ennemy = new Ennemy(90, 100, 20, 13, 12);

        //random stat ennemy
        public static Random rnd = new Random();
        public static int randomHp = rnd.Next(80, 100);
        public static int randomAttack = rnd.Next(15, 25);
        public static int randomDefense = rnd.Next(10, 15);
        public static Ennemy ennemy = new Ennemy(randomHp, randomHp, randomAttack, randomDefense, randomDefense);
        public static Sword swordLv1 = new Sword("Iron Sword", 1, "A basic iron sword.", 0.40f, 10, 1, true);
        public static Sword swordLv2 = new Sword("Steel Sword", 1, "A sturdy steel sword.", 0.40f, 25, 1, false);
        //public static List<Item> PlayerItems = new List<Item>();
        // Liste globale d'items
        public static List<Item> PlayerItems = new List<Item>
        {
            new LifePotion("Small Life Potion", 5, "Restores 20 HP.", 0.75f, 20),
            new LifePotion("Large Life Potion", 2, "Restores 100 HP.", 0.50f, 100),
            new CocaShield("Small Coca-Shield", 3, "Restores 15 Shield Points.", 0.60f, 15),
            new Sword("Iron Sword", 1, "A basic iron sword.", 0.40f, 10, 1,true),
            new Sword("Steel Sword", 1, "A sturdy steel sword.", 0.25f, 20, 2,false),
            new Armor("Leather Armor", 1, "Simple leather armor.", 0.70f, 5, 1),
            new Armor("Chainmail Armor", 1, "Armor made of interlocking metal rings.", 0.30f, 15, 2),
            new HolyPotion("Holy Potion", 1, "Restores 50 HP and 25 Shield Points.", 0.20f, 500, 500)
        };
        public static Player player = new Player(90, 100, 20, 13, 12, swordLv1, PlayerItems);


        


        


        
    }
}
