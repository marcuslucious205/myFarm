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

            //Part 2
            chicken.SetName("FogHorn");
            chicken.SetSpeak("Howdy");

            Console.WriteLine("A chicken on myFarm named {0} always says {1} when i see him. ", chicken.GetName(), chicken.GetSpeak());
            Console.ReadLine();

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
            Console.WriteLine(String.Join("\n", animals));

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

                //Part IV
                

























                //Console.WriteLine(cki.Key.ToString());

                //while (cki.Key != ConsoleKey.NoName);
            }   //Console.WriteLine("a {0} makes a {0} noise");

        }       
    }
}
