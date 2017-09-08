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

        public void FightEvil()
        {
            if (this.currentPower < 2)
            {
                Console.WriteLine("I am too weak to fight, I need to recharge.");
            }
            else
            {
                this.numberOfBattles += 1;
                this.currentPower -= 2;
                Console.WriteLine("That was tough but I survived and saved the city \n My current power is {0}.", this.currentPower);
            }
        }

        public void Sleep()
        {
            Console.WriteLine("I feel better than ever! My powers are fully recharged.");
            this.currentPower = maxPower;
        }

        public void NextLevel()
        {
            if (numberOfBattles % 3 == 0)
            {
                maxPower += 10;
                this.currentPower = this.maxPower;
            }
            else
            {
                Console.WriteLine("You don't have enough battles under your belt.");
            }
        }
    }
}
