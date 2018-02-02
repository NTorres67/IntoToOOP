using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class SuperHero
    {
        // Fields (4)
        private string name;
        private int hearingDistance;
        private bool canFly = true;
        private int topSpeed;

        // Properties (4)
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int HearingDistance
        {
            get { return this.hearingDistance; }
            set { this.hearingDistance = value; }
        }

        public bool CanFly
        {
            get { return this.canFly; }
            set { this.canFly = value; }
        }

        public int TopSpeed
        {
            get { return this.topSpeed; }
            set { this.topSpeed = value; }
        }
        

        //Behaviors(Constructors)
        public SuperHero()
        {

        }

        public SuperHero(string name, bool canFly, int topSpeed, int hearingDistance)
        {
            this.name = name;
            this.canFly = canFly;
            this.topSpeed = topSpeed;
            this.hearingDistance = hearingDistance;
        }

        //public SuperHero (string name, int topSpeed)
        //{
        //    this.name = name;
        //    this.topSpeed = topSpeed;
        //}

        //public SuperHero (string name, int hearingDistance) // ........................ ISSUE
        //{
        //    this.name = name;
        //    this.hearingDistance = hearingDistance;
        //}

        // Methods
        public void Locomotion()
        {
            if (canFly)
            {
                canFly = false;
            }
            Console.WriteLine("Afer eating peas, can " + name + " fly?" + canFly);
        }

        //public void Sound()
        //{
        //    if (hearingDistance)
        //    {
        //        hearingDistance = 200;
        //    }
        //    Console.WriteLine("After eating rice, the hearingDistance of " + name + " will increase to " + hearingDistance + " miles.");
        //}

    }
}
