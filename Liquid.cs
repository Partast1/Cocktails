using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class Liquid : Ingredient
    {
        private string color;
        bool alcohol;

        public string Color { get => color; set => color = value; }
        public bool Alcohol { get => alcohol; set => alcohol = value; }
        public Liquid()
        {

        }
        public Liquid(string cName, string cColor, bool cAlkohol) : base(cName)
        {
            color = cColor;
            alcohol = cAlkohol;
        }
    }
}
