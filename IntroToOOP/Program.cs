using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ////CAT
            //Cat firstCat = new Cat();
            //firstCat.Name = "Mr. Fuzzy";

            //Cat secondCat = new Cat("Midnight", 14, "black");

            //Console.WriteLine(firstCat.Name);
            //Console.WriteLine(secondCat.Name);

            //firstCat.Eat();

            //secondCat.Meow();

            //firstCat.HairLength = "nice and short";
            //secondCat.HairLength = "too long";

            //Console.WriteLine(firstCat.Hairball());
            //Console.WriteLine(secondCat.Hairball());

            ////Cat thirdCat = new Cat(1, true);



            //// Creating a SuperHero

            //SuperHero spOne = new SuperHero("Kilo", false, 200, 300);

            //spOne.Locomotion();



            //TOURTING PERSON
            //using default constructor
            Person firstPerson = new Person(); // variable names of the project

            Console.WriteLine(firstPerson.Name);

            firstPerson.NameChange("Bakari"); // John is now Bakari

            firstPerson.Name = ("Daniel");  // Bakari is now Daniel

            Console.WriteLine(firstPerson.Name);

            Person secondPerson = new Person("Susan");

            Console.WriteLine("What do you want to change your name to?");

            secondPerson.Name = Console.ReadLine();

            Console.WriteLine("Your new name is " + secondPerson.Name);

            Console.WriteLine("What's that? Change again? What to?!");

            string newName = Console.ReadLine();

            secondPerson.NameChange(newName);

            Console.WriteLine("Your new name is " + secondPerson.Name);





        }
    }
}
