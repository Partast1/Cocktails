using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class DrinkCard
    {
        
               public string connString = @"Server=(localdb)\MSSQLLocalDB;Database=CocktailDB;Trusted_Connection = True;";

        //Dette er et DAL lags object og det betyder at det skal servicere din applikation. Du kan derfor ikke have en void metode til at hente alle drinks! Der skal returneres en liste i stedet.
        //Det er rigtigt svært at give feedback når jeg ikke har et klassediagram!
        public void GetDrinks()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Drinks";


                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {

                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            //Ingen console writelines herinde
                            Console.WriteLine("{0}", dataReader.GetValue(i));
                            



                        }

                    }
                }
                else
                {
                    Console.WriteLine("No data found.");
                }

                conn.Close();
            }

        }
        public void DeleteDrink(int input)
        {
            
            using (SqlConnection conn = new SqlConnection(connString))
            {
                int uinput = input;
                string query = " @DELETE FROM Drinks WHERE ID=@uinput";
                //string query = " SELECT * FROM Drinks";
              

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                /*SqlDataReader dataReader =*/
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {

                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            Console.WriteLine("{0}", dataReader.(i));



                        }

                    }
                }
                else
                {
                    Console.WriteLine("No data found.");
                }

                conn.Close();
            }
        }
    }
}
