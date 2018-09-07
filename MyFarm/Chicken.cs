using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
   

    class Chicken
    {
        private string name;
        private string speak;
        //public string FogHorn;
        

        public void SetName( string Name)
        {
            this.name = Name;
            
        }
  
        public string GetName()
        {
            return name;
        }

        public void SetSpeak(string Speak)
        {
            this.speak = Speak;
        }

        public string GetSpeak()
        {
            return this.speak;
        }
     
    }
}
