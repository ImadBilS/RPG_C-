using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_C_
{
    internal class Heros
    {
        //Attributs
        private int nbPv;
        private int nbPvMax;
        private int nbAttaque;
        private int nbDefenseMax;
        private int nbDefense;

        //Propriétés
        public Heros(int nbPv, int nbPvMax, int nbAttaque, int nbDefenseMax, int nbDefense)
        {
            this.nbPv = nbPv;
            this.nbPvMax = nbPvMax;
            this.nbAttaque = nbAttaque;
            this.nbDefenseMax = nbDefenseMax;
            this.nbDefense = nbDefense;
        }


        //Accesseurs
        public int getNbPv()
        {
            return this.nbPv;
        }
        public int getNbPvMax()
        {
            return this.nbPvMax;
        }
        public int getNbAttaque()
        {
            return this.nbAttaque;
        }
        public int getNbDefense()
        {
            return this.nbDefense;
        }
        public int getNbDefenseMax()
        {
            return this.nbDefenseMax;
        }
        //Mutateurs
        public void setNbPv(int nbPv)
        {
            this.nbPv = nbPv;
        }
        public void setNbPvMax(int nbPvMax)
        {
            this.nbPvMax = nbPvMax;
        }
        public void setNbAttaque(int nbAttaque)
        {
            this.nbAttaque = nbAttaque;
        }
        public void setNbDefense(int nbDefense)
        {
            this.nbDefense = nbDefense;
        }
        public void setNbDefenseMax(int nbDefenseMax)
        {
            this.nbDefenseMax = nbDefenseMax;
        }

        //Méthodes
        //public void attaquer(heros h)
        //{

        // }
    }
}
