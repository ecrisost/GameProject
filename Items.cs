using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Items
    {
        public Items () { }
        public int Buying_Price { get; set; }
        public int Selling_Price { get; set; }
        public Item_Types Itm_Type { get; set; }
        public Rarity Type_Rarity { get; set; }
        public string Name { get; set;}
        public int Num_Items { get; set; }
       
    }
}
