using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_C_
{
    internal class Monster
    {
        private int CurrentHp;
        private int MaxHp;
        private int Attack;
        private int MaxDefense;
        private int CurrentDefense;

        public Monster(int CurrentHp, int MaxHp, int Attack, int MaxDefense, int CurrentDefense)
        {
            this.CurrentHp = CurrentHp;
            this.MaxHp = MaxHp;
            this.Attack = Attack;
            this.MaxDefense = MaxDefense;
            this.CurrentDefense = CurrentDefense;
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
        public int GetCurrentDefense()
        {
            return this.CurrentDefense;
        }
        public int GetMaxDefense()
        {
            return this.MaxDefense;
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
        public void SetCurrentDefense(int CurrentDefense)
        {
            this.CurrentDefense = CurrentDefense;
        }
        public void SetMaxDefense(int MaxDefense)
        {
            this.MaxDefense = MaxDefense;
        }

        public void AttackHero(Heros hero)
        {
            int damage = this.Attack - hero.GetCurrentDefense();
            if (damage < 0)
            {
                damage = 0;
            }
            hero.SetCurrentHp(hero.GetCurrentHp() - damage);
        }
    }
}
