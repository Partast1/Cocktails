using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class Item : Entity
    {
        private int unit;
        private Ingredient ingredient;

        public Ingredient Ingredient
        {
            get { return ingredient; }
            set { ingredient = value; }
        }

        public int Unit { get => unit; set => unit = value; }

        public Item()
        {

        }
        public Item(int cUnit, Ingredient cIngredient)
        {
            Ingredient = cIngredient;
            unit = cUnit;

        }
    }
}
