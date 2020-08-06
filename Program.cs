using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ingredient ing = new Ingredient();
            DrinkCrud dc = new DrinkCrud();

            DrinkContext ctx = new DrinkContext();
            Console.WriteLine("Press 1 for drinks: press 2 for delete: press 3 for updating a drink");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    var displayDrinks = dc.GetDrinks();
                    foreach ( Drink drink in displayDrinks)
                    {
                        Console.WriteLine(drink.Name);
                    }
                    break;
                case 2:
                    int inputDel = Convert.ToInt32(Console.ReadLine());
                    dc.DeleteDrink(inputDel);
                    break;
                    

            }
            ctx.Ingredients.Add(ing);  
        }
    }
}
