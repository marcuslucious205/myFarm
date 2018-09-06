using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
  

    class Program
    {
       
        public static void Main(string[] args)
        {
            string c = "Chicken";
            string a = "Cow";
            string g = "Goat";
            string p = "Pig";


            Animal animal = new Animal();


            Console.WriteLine("Welcome to myFarm");
            Console.WriteLine("On myfarm we have " +c+ " ," +a+ " ," +g+ " and " + p);

            Console.WriteLine("We have these animals on myFarm");
            //Animal.name = "Chicken, Cow, Goat, Pig";
            Chicken(animal);
            Cow(animal);
            Goat(animal);
            Pig(animal);

        }

        private static void Pig(Animal animal)
        {
            throw new NotImplementedException();
        }

        private static void Goat(Animal animal)
        {
            throw new NotImplementedException();
        }

        private static void Cow(Animal animal)
        {
            throw new NotImplementedException();
        }

        private static void Chicken(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
