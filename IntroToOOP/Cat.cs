using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //these are FIELDS. they are private so they cannot be changed 
        private string name;
        private string furColor;
        private int furLength;
        private int age;
        private bool isFixed;
        private bool isHungry;
        

        //these are PROPERTIES they are public and allow the user to access the private fields
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string FurColor
        {
            get { return this.furColor;}
            set { this.furColor = value; }
        
        }

        public int Age
        {
            get { return this.age; }  //not letting the user change the age, starts at zero
        }

        public bool IsFixed
        {
            get { return this.isHungry; }
            set { this.isFixed = value; }
        }

        
        

        public Cat()
        {

        }

        //this is constructor which requires 
        public Cat(string name, string furColor, int furLength, int age, bool isFixed, bool isHungry)
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isFixed = isFixed;
            this.isHungry = isHungry;
        }

        // METHODS creating behaviors for this class

        public void Eat()
        {
            if(isHungry)
            {
                isHungry = false;
                Console.WriteLine("I don't need to eat.");
            }

            else if(!isHungry)
            {
                Console.WriteLine("Give me food!");
            }
        }

        

        public void Run()
        {
            Console.WriteLine("I am running all around!");
            this.isHungry = true;
        }

        public void Alter()
        {
            if (!isFixed)
            {
                Console.WriteLine("Get that cat fixed!");
            }
            else if (isFixed)
            {
                Console.WriteLine("Thank you for being a responsible pet owner.");
            }
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping, do not disturd!");
        }
        
        public void Talk()
        {
            Console.WriteLine("Meow meow MEOW!! My name is {0} and I like you", this.name );
        }
    }
}
