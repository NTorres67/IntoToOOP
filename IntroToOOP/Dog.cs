using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {

        // Fields
        private string hairLength;
        private double height;
        private int runningSpeed;
        private double weight;
        private bool run = true;
        private bool potty = true;
        private bool cuddle = true;


        // Properties
        public string HairLength
        {
            get {return this.hairLength; }
            set {this.hairLength = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public bool Run
        {
            get { return this.run; }
            set { this.run = value; }
        }

        public bool Potty
        {
            get { return this.potty; }
            set { this.potty = value; }
        }

        public bool Cuddle
        {
            get { return this.cuddle; }
            set { this.cuddle = value; }
        }

        // BEHAVIORS (Constructors)
        public Dog()
        {

        }

        public Dog (string hairLength, double height, int runningSpeed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;

        } 

        public Dog(bool run)
        {
            this.run = run;
        }

        //public Dog(bool potty) // .............. ISSUE
        //{
        //    this.potty = potty;
        //}

        //public Dog(bool cuddle) // ..............ISSUE
        //{
        //    this.cuddle = cuddle;
        //}

        // Method
        public void Exercise() 
        {
            if (run)
            {
                run = false;
            }
            Console.WriteLine("Your dog likes to run." + run);

        }

        public void Woof()
        {
            Console.WriteLine("\a");
        }

        public void Bathroom()
        {
            if (potty)
            {
                potty = false;
            }
            Console.WriteLine("Your dog went potty." + potty);
        }

        public void Snuggle()
        {
            if (cuddle)
            {
                cuddle = false;
            }
            Console.WriteLine("Your dog likes to cuddle.");
        }
            


    }
}
