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

            Chicken chicken = new Chicken();
            Cow cow = new Cow();
            Goat goat = new Goat();
            Pig pig = new Pig();

            //Part 1
            Console.WriteLine("Welcome to myFarm");
            Console.WriteLine("On myfarm we have " + c + " ," + a + " ," + g + " and " + p);
            Console.Clear();

            //Part 2
            chicken.SetName("FogHorn");
            chicken.SetSpeak("Howdy");

            Console.WriteLine("A chicken on myFarm named {0} always says {1} when i see him. ", chicken.GetName(), chicken.GetSpeak());
            Console.ReadLine();
            Console.Clear();

            //Part 3
            pig.SetName("Charlotte");
            pig.SetSpeak("oh Wilbur");
            cow.SetName("MilkShake");
            cow.SetSpeak("Got Milk");
            goat.SetName("Billy");
            goat.SetSpeak("Cram");

            string[] animals = new string[4] { "Chicken", "Cow", "Goat", "Pig" };
            string[] animals2 = new string[4] { "CLUCK", "MOO", "BAA", "OINK" };

            Console.WriteLine("These animals live on myfarm");
            Console.WriteLine(string.Join("\n", animals));
            

            while (true)//Loop indefinitely
            {
                Console.WriteLine("Choose an animal and I'll tell you what sound it makes");
                string line = System.Console.ReadLine();
                if (line == "Pig")
                {
                    Console.WriteLine("{0} says {1}.", pig.GetName(), pig.GetSpeak());
                    break;
                }

                else if (line == "Cow")
                {
                    Console.WriteLine("{0} says {1}.", cow.GetName(), cow.GetSpeak());
                    break;
                }

                else
                {
                    Console.WriteLine("{0} says {1}.", goat.GetName(), goat.GetSpeak());
                    break;
                }
            }
            Console.Read();
            Console.Clear();
            

            //Part IV
            chicken.SetColor("white");
            chicken.SetEat("corn");
            pig.SetColor("pink");
            pig.SetEat("slop");
            goat.SetColor("purple");
            goat.SetEat("trash");
            cow.SetColor("brown");
            cow.SetEat("grass"); 


            Console.WriteLine("On my farm i have a {0} chicken named {1} that eats {3} and says {2} ", chicken.GetColor(), chicken.GetName(), chicken.GetSpeak(), chicken.GetEat());
            Console.WriteLine("On my farm i have a {0} pig named {1} that eats {3} and says {2} ", pig.GetColor(), pig.GetName(), pig.GetSpeak(), pig.GetEat());
            Console.WriteLine("On my farm i have a {0} goat named {1} that eats {3} and says {2} ", goat.GetColor(), goat.GetName(), goat.GetSpeak(), goat.GetEat());
            Console.WriteLine("On my farm i have a {0} cow named {1} that eats {3} and says {2} ", cow.GetColor(), cow.GetName(), cow.GetSpeak(), cow.GetEat());
            Console.ReadLine();



        }       
    }
}
