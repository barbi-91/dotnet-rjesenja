/*
 * Using classes and objects, create a simple application structure based on image in the project attachment (_002_exercise_example.png)
 * 
 */

namespace _002_exercise;

internal class Program
{
    static void Main(string[] args)
    {

        // Create two objects of the Order class.
        // Create 10 objects of the OrderItem class and arbitrarily associate them with the OrderItems property

        //OrderItem 1 - 10
        OrderItem item1 = new OrderItem();
        item1.ID = 334;
        item1.ItemName = "apple";
        item1.ItemPrice = 45.67F;
        item1.ItemQuantity = 6;
        item1.CalculateTotal();

        OrderItem item2 = new OrderItem();
        item2.ID = 123;
        item2.ItemName = "strawberries";
        item2.ItemPrice = 7.34F;
        item2.ItemQuantity = 2;
        item2.CalculateTotal();

        OrderItem item3 = new OrderItem();
        item3.ID = 453;
        item3.ItemName = "tea";
        item3.ItemPrice = 12.38F;
        item3.ItemQuantity = 1;
        item3.CalculateTotal();

        OrderItem item4 = new OrderItem();
        item4.ID = 36;
        item4.ItemName = "bread";
        item4.ItemPrice = 3.25F;
        item4.ItemQuantity = 2;
        item4.CalculateTotal();

        OrderItem item5 = new OrderItem();
        item5.ID = 122;
        item5.ItemName = "orange";
        item5.ItemPrice = 3.15F;
        item5.ItemQuantity = 7;
        item5.CalculateTotal();

        OrderItem item6 = new OrderItem();
        item6.ID = 22;
        item6.ItemName = "coffee";
        item6.ItemPrice = 5.5F;
        item6.ItemQuantity = 1;
        item6.CalculateTotal();

        OrderItem item7 = new OrderItem();
        item7.ID = 221;
        item7.ItemName = "powder";
        item7.ItemPrice = 3.5F;
        item7.ItemQuantity = 1;
        item7.CalculateTotal();

        OrderItem item8 = new OrderItem();
        item8.ID = 31;
        item8.ItemName = "milk";
        item8.ItemPrice = 2.55F;
        item8.ItemQuantity = 4;
        item8.CalculateTotal();

        OrderItem item9 = new OrderItem();
        item9.ID = 2221;
        item9.ItemName = "skin cream";
        item9.ItemPrice = 50.49F;
        item9.ItemQuantity = 1;
        item9.CalculateTotal();

        OrderItem item10 = new OrderItem();
        item10.ID = 2223;
        item10.ItemName = "sugar";
        item10.ItemPrice = 1.5F;
        item10.ItemQuantity = 2;
        item10.CalculateTotal();

        ////order 1
        Order order1 = new Order();
        order1.ID = 1111;
        order1.OrderDate = DateTime.Now;
        order1.CreateBy = "Ana Programeric";

        List<OrderItem> listOrderItems1 = new List<OrderItem>();
        order1.OrderItems = listOrderItems1;
        order1.OrderItems.Add(item1);
        order1.OrderItems.Add(item3);
        order1.OrderItems.Add(item5);
        order1.OrderItems.Add(item7);
        order1.OrderItems.Add(item9);


        //order 2
        Order order2 = new Order();
        order2.ID = 2222;
        order2.OrderDate = DateTime.Now;
        order2.CreateBy = " Michael Dizajneric";

        List<OrderItem> listOrderItems2 = new List<OrderItem>();
        order2.OrderItems = listOrderItems2;
        order2.OrderItems.Add(item2);
        order2.OrderItems.Add(item4);
        order2.OrderItems.Add(item6);
        order2.OrderItems.Add(item8);
        order2.OrderItems.Add(item10);

        //Print order1
        Console.WriteLine("*********************");
        Console.WriteLine($"Order ID: {order1.ID}");
        Console.WriteLine($"Order Date: {order1.OrderDate}");
        Console.WriteLine($"Order is create by: {order1.CreateBy}");
        Console.WriteLine("*****");
        order1.PrintOrder(listOrderItems1);
        Console.WriteLine("*****");
        Console.WriteLine("Order Total: " + order1.CalculateTotal(order1.OrderItems));
        Console.WriteLine("*****");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        //Print order2
        Console.WriteLine("*********************");
        Console.WriteLine($"Order ID: {order2.ID}");
        Console.WriteLine($"Order Date: {order2.OrderDate}");
        Console.WriteLine($"Order is create by: {order2.CreateBy}");
        Console.WriteLine("*****");
        order1.PrintOrder(listOrderItems2);
        Console.WriteLine("*****");
        Console.WriteLine("Order Total: " + order2.CalculateTotal(order2.OrderItems));
        Console.WriteLine("*****");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        // This is only here to stop the program before exiting
        Console.ReadKey();
    }
}