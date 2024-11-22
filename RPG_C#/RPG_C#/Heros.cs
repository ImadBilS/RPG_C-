using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_C_
{
    internal class Heros
    {
        private int CurrentHp;
        private int MaxHp;
        private int Attack;
        private int Defense;
        private int Shield;

        public Heros(int CurrentHp, int MaxHp, int Attack, int Defense, int Shield)
        {
            this.CurrentHp = CurrentHp;
            this.MaxHp = MaxHp;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Shield = Shield;
        }

        public int GetCurrentHp()
        {
            return this.CurrentHp;
        }
        public int GetMaxHp()
        {
            return this.MaxHp;
        }
        public int GetAttack()
        {
            return this.Attack;
        }
        public int GetShield()
        {
            return this.Shield;
        }
        public int GetDefense()
        {
            return this.Defense;
        }
        

        public void SetCurrentHp(int CurrentHp)
        {
            this.CurrentHp = CurrentHp;
        }
        public void SetMaxHp(int MaxHp)
        {
            this.MaxHp = MaxHp;
        }
        public void SetAttack(int Attack)
        {
            this.Attack = Attack;
        }
        public void SetShield(int Shield)
        {
            this.Shield = Shield;
        }
        public void SetDefense(int Defense)
        {
            this.Defense = Defense;
        }

        //Méthodes
        public void attackAMonster(Monster monster)
        {
            int damage = this.Attack - monster.GetShield();
            
            if (monster.GetCurrentHp() - this.Attack > 0)
            {
                monster.SetCurrentHp(monster.GetCurrentHp() - damage);
            }
            else
            {
                monster.SetCurrentHp(0);
            }
        }

        public void heal()
        {
            if (this.CurrentHp + 10 < this.MaxHp)
            {
                this.CurrentHp += 10;
            }
            else
            {
                this.CurrentHp = this.MaxHp;
            }
        }
    }
}
