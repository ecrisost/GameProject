using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GameProject
{
    class Player
    {

        public Player() { }
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Gold { get ; set; }
        public int Maps { get; set; }
        public bool IsAtBazaar { get; set; }
        private static readonly int MAX_INVENTORY = 100; //max size of inventory
        public static int index = 0;
        public Dictionary<int, Items> Inventory = new Dictionary<int, Items>();
        
        public void Buy (Items itm)
        {
            if(Inventory.Count > MAX_INVENTORY)
            {
                Console.WriteLine("Inventory Full");
            }
            else
            {
                Inventory.Add(index, itm);
                index++;
            }
            
        }

        public void Sell(int itm)
        {
            Inventory.Remove(itm);
            index--;
        }

        public void Print_Invetory()
        {
            Console.Write("\t\tItem\tPrice\n");
            for(int i = 0; i < index; i++)
            {
                Console.Write($"\t{i} \t{Inventory[i].Name} \t{Inventory[i].Buying_Price}\n");
            }
        }
    }
}
