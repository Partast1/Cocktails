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
            //List<Item> items = new List<Item>()
            //{
            //    new Item(2,new Liquid("test", "test", false)),
            //    new Item(2, new Liquid("test2", "test2", true))
            //};
           
            Ingredient ing = new Ingredient();
            DrinkCard dk = new DrinkCard();

            DrinkContext ctx = new DrinkContext();
            Console.WriteLine("Press 1 for drinks: press 2 for delete: press 3 for updating a drink");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    dk.GetDrinks();
                    break;
                case 2:
                    int inputDel = Convert.ToInt32(Console.ReadLine());
                    dk.DeleteDrink(inputDel);
                    break;
                    

            }
            ctx.Ingredients.Add(ing);
            //DrinkContext dctx = new DrinkContext();
            //Drink drik = new Drink("Barcadis", items);

            //DrinkContext dcxt
        
                //ite.Items = ctx.items.Where(o => o.Id == ite.Id);


            
        }
    }
}
