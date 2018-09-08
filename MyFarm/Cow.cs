using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{

    class Cow
    {
        private string name;
        private string speak;
        private string eat;
        private string color;

        public void SetName(string Name) => this.name = Name;
        public string GetName() => name;

        public void SetSpeak(string Speak) => this.speak = Speak;
        public string GetSpeak() => this.speak;

        public void SetColor(string Color) => this.color = Color;
        public string GetColor() => this.color;

        public void SetEat(string Eat) => this.eat = Eat;
        public string GetEat() => this.eat;
    }
}
