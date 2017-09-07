using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //FIELDS
        private int hairLength;
        private double height;
        private double runningSpeed;
        private int weight;

        //PROPERTIES

        public int HairLength
        {
            get { return this.hairLength; }
            set { this.HairLength = value; }
        }
        public double Height
        { 
            get {return this.height;}
            set { this.height = value; }
            
        }
        public double RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.runningSpeed = value; }
        }
        //CONSTRUCTORS

                //DEFAULT constructor 
        public Dog()
        {
            this.weight = 220;
            this.height = 3d;
            this.hairLength = 2;
            this.runningSpeed = 45d;
        }

                // OVERLOADING
        public Dog (double height, double runningSpeed, int hairLength, int weight)
        {
            this.weight = weight;
            this.height = height;
            this.hairLength = hairLength;
            this.runningSpeed = runningSpeed;
        }

            //BEHAVIORS 
        
        public void Run()
        {
            Console.WriteLine("Woof, I'm gonna run after that rabbit!");
        }
        public void Cuddle( string name )
        {
            Console.WriteLine("Thank you {0} for cuddling with  me.", name);
        }
    
    }
}
