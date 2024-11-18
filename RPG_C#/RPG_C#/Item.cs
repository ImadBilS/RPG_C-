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
    }
}
