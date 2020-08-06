using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class Drink : Entity
    {
        private string name;
        private List<Item> items;

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }

        public string Name { get => name; set => name = value; }

        public Drink()
        {

        }
        public Drink(string cName, List<Item> cItems)
        {
            name = cName;
            Items = cItems;
        }
    }
}
