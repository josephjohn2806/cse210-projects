using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: A customer in Kenya
        Address addr1 = new Address("Ngong Road", "Nairobi", "Nairobi", "Kenya");
        Customer cust1 = new Customer("Jabari Kamau", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Kericho Gold Tea", "TEA-001", 5.50, 3));
        order1.AddProduct(new Product("Handmade Kiondo Bag", "BAG-99", 25.00, 1));

        // Order 2: A customer in the USA
        Address addr2 = new Address("123 Maple St", "Seattle", "WA", "USA");
        Customer cust2 = new Customer("Joseph John", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Kenya AA Coffee Beans", "COF-500", 18.00, 2));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotal():0.00}\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotal():0.00}");
    }
}