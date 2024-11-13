using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_C_
{
    internal class Personnage
    {
        private int CurrentHp;
        private int MaxHp;
        private int AttackPower;
        private int MaxDefense;
        private int CurrentDefense;
        private bool isDead;

        public Personnage(int CurrentHp, int MaxHp, int Attack, int MaxDefense, int CurrentDefense)
        {
            this.CurrentHp = CurrentHp;
            this.MaxHp = MaxHp;
            this.AttackPower = Attack;
            this.MaxDefense = MaxDefense;
            this.CurrentDefense = CurrentDefense;
            this.isDead = false;
        }

        //GETTERS
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
        public int GetCurrentDefense()
        {
            return this.CurrentDefense;
        }
        public int GetMaxDefense()
        {
            return this.MaxDefense;
        }
        public bool GetIsDead()
        {
            return this.isDead;
        }

        //SETTERS
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
        public void SetCurrentDefense(int CurrentDefense)
        {
            this.CurrentDefense = CurrentDefense;
        }
        public void SetMaxDefense(int MaxDefense)
        {
            this.MaxDefense = MaxDefense;
        }
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
        private int nbLifePotion;

        public Player(int CurrentHp, int MaxHp, int Attack, int MaxDefense, int CurrentDefense, int nbLifePotion) : base(CurrentHp, MaxHp, Attack, MaxDefense, CurrentDefense)
        {
            this.nbLifePotion = nbLifePotion;
        }

        public int getNbLifePotion()
        {
            return this.nbLifePotion;
        }

        public void setNbLifePotion(int nbLifePotion)
        {
            this.nbLifePotion = nbLifePotion;
        }


        public void attackEnnemy(Ennemy ennemy)
        {
            int damage = this.GetAttackPower() - ennemy.GetCurrentDefense();
            if (ennemy.GetCurrentHp() - this.GetAttackPower() > 0)
            {
                ennemy.SetCurrentHp(ennemy.GetCurrentHp() - damage);
            }
            else
            {
                ennemy.SetCurrentHp(0);
            }
        }

        public void heal()
        {
            if (this.nbLifePotion > 0)
            {
                this.SetCurrentHp(this.GetCurrentHp() + 20);
                this.nbLifePotion -= 1;
            }
        }
    }

    class Ennemy : Personnage
    {
        public Ennemy(int CurrentHp, int MaxHp, int Attack, int MaxDefense, int CurrentDefense) : base(CurrentHp, MaxHp, Attack, MaxDefense, CurrentDefense)
        {

        }

        public void attackPlayer(Player player)
        {
            int damage = this.GetAttackPower() - player.GetCurrentDefense();
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
