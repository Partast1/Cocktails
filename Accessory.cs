using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{

       public class Accessory : Ingredient
        {
            private string type;

            public string Type { get => type; set => type = value; }

            public Accessory()
            {

            }
            public Accessory(string cName, string cType) : base(cName)
            {
                type = cType;
            }
        }
}
