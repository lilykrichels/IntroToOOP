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

    }
}
