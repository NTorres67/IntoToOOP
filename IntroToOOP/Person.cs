using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Person
    {
        //fields and Properties
        // - What's all this "get set" nonsense?
        private string name; //this is a field

        public string Name //This is a Property
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //Constructors
        // - What are they exactly?
        public Person() //this is a default constructor
        {
            this.name = "John";
        }

        public Person(string name) //overloaded constructor
        {
            this.name = name;
        }

        //Methods
        // - How do they interact with fields or Properties?
        public void NameChange(string newName) //this is a method that returns nothing
        {
            this.name = newName;
        }
    }
}
