using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("144 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Agent Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Black Aviator Sunglasses", "B246", 10, 1));
        order1.AddProduct(new Product("Computer Simulator", "C135", 15, 1));

        Address address2 = new Address("960 Matrix Dr", "Paris", "France", "EU");
        Customer customer2 = new Customer("Neo Anderson", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Human Flight Stabilizer", "H333", 6, 2));
        order2.AddProduct(new Product("6 Foot Metal Rod", "M605", 21, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}