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
            //Cow cow = new Cow();
            //Goat goat = new Goat();
            //Pig pig = new Pig();

 
            Console.WriteLine("Welcome to myFarm");
            Console.WriteLine("On myfarm we have " + c + " ," + a + " ," + g + " and " + p);


            chicken.SetName("FogHorn");
           

            Console.WriteLine("A chicken on myFarm named {0}", chicken.GetName());
            Console.ReadKey();
            //" always says " ( chicken.GetSpeak) " when I see him ");
            




        }
    }
}
