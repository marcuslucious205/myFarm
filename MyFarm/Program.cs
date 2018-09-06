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

            Animal chicken = new Animal();
            Animal cow = new Animal();
            Animal goat = new Animal();
            Animal pig = new Animal();

            //Animal animal = new Animal();



            Console.WriteLine("Welcome to myFarm");
            Console.WriteLine("On myfarm we have " +c+ " ," +a+ " ," +g+ " and " + p);

            //Console.WriteLine("We have these animals on myFarm");
            //Animal.name = "Chicken, Cow, Goat, Pig";
            chicken.name = "FogHorn";
            chicken.speak = "Howdy";
            //Cow(animal);
            //Goat(animal);
            //Pig(animal);

            Console.WriteLine("A chicken on my farm named " + chicken.name + " always says " + chicken.speak + " when I see him ");


        }

      private static void Pig(Animal animal)
        {
            throw new NotImplementedException();
        }

        private static void Goat(Animal Billy)
        {
            throw new NotImplementedException();
        }

        private static void Cow(Animal Clarabelle)
        {
            throw new NotImplementedException();
        }
        
        public static void Chicken(Animal FogHorn)
        {
            throw new NotImplementedException();
           //Chicken.name = chicken;



        }
    }
}
