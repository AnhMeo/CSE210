using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Address address2 = new Address("456 Cherry Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MSE456", 19.99, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "KBD789", 49.99, 1));
        order2.AddProduct(new Product("Monitor", "MON101", 199.99, 1));

        // Print order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}