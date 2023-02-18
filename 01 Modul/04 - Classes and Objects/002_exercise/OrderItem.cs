using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_exercise
{
    internal class OrderItem
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public float ItemQuantity { get; set; }
        public float ItemPrice { get; set; }


        public float CalculateTotal()
        {
            return ItemQuantity * ItemPrice;
        }


    }
}
