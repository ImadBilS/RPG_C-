using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_C_
{
    internal class Item
    {
        private string name;
        private int quantity;
        private string description;
        private Single dropRate;

        public Item(string name, int quantity, string description, Single dropRate)
        {
            this.name = name;
            this.quantity = quantity;
            this.description = description;
            this.dropRate = dropRate;
        }

        //GETTERS
        public string GetName()
        {
            return this.name;
        }
        public int GetQuantity()
        {
            return this.quantity;
        }
        public string GetDescription()
        {
            return this.description;
        }
        public Single GetDropRate()
        {
            return this.dropRate;
        }
        //SETTERS
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }
        public void SetDropRate(Single dropRate)
        {
            this.dropRate = dropRate;
        }
    }

    class LifePotion:Item
    {
        private int lifePointRestored;

        public LifePotion(string name, int quantity, string description, Single dropRate, int lifePointRestored) : base(name, quantity, description, dropRate)
        {
            this.lifePointRestored = lifePointRestored;
        }

        public int getLifePointRestored()
        {
            return this.lifePointRestored;
        }
        public void setLifePointRestored(int lifePointRestored)
        {
            this.lifePointRestored = lifePointRestored;
        }
    }

    class CocaShield: Item
    {
        private int shieldPointRestored;

        public CocaShield(string name, int quantity, string description, Single dropRate, int shieldPointRestored) : base(name, quantity, description, dropRate)
        {
            this.shieldPointRestored = shieldPointRestored;
        }
    }

    class Sword : Item
    {
        private int attackPower;
        private int level;
        private bool isEquipped;

        public Sword(string name, int quantity, string description, Single dropRate, int attackPower, int level, bool isEquipped) : base(name, quantity, description, dropRate)
        {
            this.attackPower = attackPower;
            this.level = level;
            this.isEquipped = isEquipped;
        }
        public int getAttackPower() { return this.attackPower; }
        public void setAttackPower(int attackPower) { this.attackPower = attackPower; }
        public int getLevel() { return this.level; }
        public void setLevel(int level) { this.level = level; }
        public bool getIsEquipped() { return this.isEquipped; }
        public void setIsEquipped(bool isEquipped) { this.isEquipped = isEquipped; }
    }

    class Armor : Item
    {
        private int defensePower;
        private int level;

        public Armor(string name, int quantity, string description, Single dropRate, int defensePower, int level) : base(name, quantity, description, dropRate)
        {
            this.defensePower = defensePower;
            this.level = level;
        }

    }

    class HolyPotion : Item
    {
        private int lifePointRestored;
        private int shieldPointRestored;

        public HolyPotion(string name, int quantity, string description, Single dropRate, int lifePointRestored, int shieldPointRestored) : base(name, quantity, description, dropRate)
        {
            this.lifePointRestored = lifePointRestored;
            this.shieldPointRestored = shieldPointRestored;
        }
    }
}
