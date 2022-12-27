using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_exercise
{
    internal class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public string CreateBy { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public float CalculateTotal(List<OrderItem> ListOfValueObjects)
        {
            float total = 0;
            foreach (OrderItem item in ListOfValueObjects)
            {
                total = total + item.CalculateTotal();

            }
            return total;
        }

        public void PrintOrder(List<OrderItem> ListOfValueObjects)
        {
            var counter = 0;
            foreach (var item in ListOfValueObjects)
            {
                counter++;
                Console.WriteLine($" Item: {counter}, Item ID: {item.ID}, Item Name: {item.ItemName}, Item Quantity: {item.ItemQuantity}, Item  Price: {item.ItemPrice}, Item Total: {item.CalculateTotal()}");
            }
        }


    }
}
