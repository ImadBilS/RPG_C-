using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace RPG_C_
{
    internal class Personnage
    {
        private int CurrentHp;
        private int MaxHp;
        private int AttackPower;
        private int Defense;
        private int Shield;
        private bool isDead;
        //inventaire a faire 
        public Personnage(int CurrentHp, int MaxHp, int Attack, int Defense, int Shield)
        {
            this.CurrentHp = CurrentHp;
            this.MaxHp = MaxHp;
            this.AttackPower = Attack;
            this.Defense = Defense;
            this.Shield = Shield;
            this.isDead = false;
        }

        // GETTERS
        public int GetCurrentHp()
        {
            return this.CurrentHp;
        }
        public int GetMaxHp()
        {
            return this.MaxHp;
        }
        public int GetAttackPower()
        {
            return this.AttackPower;
        }
        public int GetShield()
        {
            return this.Shield;
        }
        public int GetDefense()
        {
            return this.Defense;
        }
        public bool GetIsDead()
        {
            return this.isDead;
        }

        // SETTERS
        public void SetCurrentHp(int CurrentHp)
        {
            this.CurrentHp = CurrentHp;
        }
        public void SetMaxHp(int MaxHp)
        {
            this.MaxHp = MaxHp;
        }
        public void SetAttackPower(int Attack)
        {
            this.AttackPower = Attack;
        }
        public void SetShield(int Shield)
        {
            this.Shield = Shield;
        }
        public void SetDefense(int Defense)
        {
            this.Defense = Defense;
        }

        // Méthode pour vérifier si le personnage est mort
        public bool hasDied()
        {
            if (this.CurrentHp <= 0)
            {
                this.isDead = true;
            }
            return this.isDead;
        }
    }

    class Player : Personnage
    {
        private Sword sword; // Ajout de l'épée équipée
        private List<Item> inventory = new List<Item>();


        public Player(int CurrentHp, int MaxHp, int Attack, int Defense, int Shield, Sword sword, List<Item> inventory)
            : base(CurrentHp, MaxHp, Attack, Defense, Shield)
        {
            this.sword = sword;
            base.SetAttackPower(Attack + sword.getAttackPower());
            this.inventory = new List<Item>();
        }


        public Sword GetSword()
        {
            return this.sword;
        }
        public void equipNewSword(Sword newSword)
        {
            int oldSwordAttack = this.sword.getAttackPower();
            this.sword.setIsEquipped(false);
            this.sword = newSword;
            newSword.setIsEquipped(true);
            this.SetAttackPower(this.GetAttackPower() - oldSwordAttack + newSword.getAttackPower());
        }


        public void attackEnnemy(Ennemy ennemy)
        {
            int damage = this.GetAttackPower() - ennemy.GetShield();
            if (ennemy.GetCurrentHp() - this.GetAttackPower() > 0)
            {
                ennemy.SetCurrentHp(ennemy.GetCurrentHp() - damage);
            }
            else
            {
                ennemy.SetCurrentHp(0);
            }
        }
        
        public void useLifePotion(Item lifePotion)
        {
            
        }

        /*
        // Méthode pour utiliser une potion de vie depuis l'inventaire
        public void UseLifePotion()
        {
            Item potion = inventory.("Life Potion");

            if (potion != null)
            {
                LifePotion lifePotion = (LifePotion)potion;
                this.SetCurrentHp(Math.Min(this.GetMaxHp(), this.GetCurrentHp() + lifePotion.getLifePointRestored()));
                inventory.RemoveItem(potion,1);
            }
        }
        */
    }

    class Ennemy : Personnage
    {
        public Ennemy(int CurrentHp, int MaxHp, int Attack, int Defense, int Shield)
            : base(CurrentHp, MaxHp, Attack, Defense, Shield)
        {
        }

        public void attackPlayer(Player player)
        {
            int damage = this.GetAttackPower() - player.GetShield();
            if (player.GetCurrentHp() - this.GetAttackPower() > 0)
            {
                player.SetCurrentHp(player.GetCurrentHp() - damage);
            }
            else
            {
                player.SetCurrentHp(0);
            }
        }
    }
}
