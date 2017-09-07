using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Superhero
    {
        //FIELDS

        private string alterEgo;
        private int currentPower;
        private int maxPower;
        private int numberOfBattles;
        
        //PROPERIES
        
        public string AlterEgo
        {
            get { return this.alterEgo; }
            set { this.alterEgo = value; }
        }

        public int CurrentPower
        {
            get { return this.currentPower; }
        }

        public int MaxPower
        {
            get { return this.maxPower; }           
        }

        public int NumberOfBatles
        {
            get { return this.maxPower; }
        }

        //CONSTRUCTORS

        public Superhero()
        {
            this.alterEgo = "Bag Guy";
            this.currentPower = 5;
            this.maxPower = 5;
            this.numberOfBattles = 0;
        }

        public Superhero(string alterEgo)
        {
            this.alterEgo = alterEgo;
            this.currentPower = 10;
            this.maxPower = 10;
            this.numberOfBattles = 0;
        }

        //METHODS


    }
}
