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
        private bool isMale;
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
        

        public Cat()
        {

        }

        //this is constructor which requires 
        public Cat(string name, string furColor, int furLength, int age, bool isMale, bool isHungry)
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;
        }

    }
}
