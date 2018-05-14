using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GameProject
{
    enum Item_Types { Potion, Food, Drink,  Treasure };
    enum Rarity { Common, Rare, Legendary };
    class Program
    {
        
        static void Main(string[] args)
        {
            int MAX_HUNGER = 50;
            int MAX_HEALTH = 100;
            int MAX_THIRST = 50;
            int STARTING_GOLD = 200;
            //int MAX_INVENTORY = 100;
           
            Console.WriteLine("Welcome to Archaelogy. Press Any Key to Continue...\n");
            Console.ReadLine();


            Player p = new Player { Health = MAX_HEALTH, Gold = STARTING_GOLD, Hunger = MAX_HUNGER, Thirst = MAX_THIRST };
            Items Common_Potion = new Items { Buying_Price  = 10, Selling_Price = 5, Itm_Type = Item_Types.Potion, Type_Rarity = Rarity.Common, Num_Items = 5 };
            Items Comm_Food = new Items { Buying_Price = 5, Selling_Price = 2, Itm_Type = Item_Types.Food, Type_Rarity = Rarity.Common };
        }
    }
}
