using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street",
            "Rexburg",
            "Idaho",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Order order1 = new Order(customer1);

        Product product1 = new Product(
            "Headphones",
            "H100",
            25.00,
            2
        );

        Product product2 = new Product(
            "Keyboard",
            "K200",
            40.00,
            1
        );

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address(
            "55 King Road",
            "Toronto",
            "Ontario",
            "Canada"
        );

        Customer customer2 = new Customer(
            "Mary Johnson",
            address2
        );

        Order order2 = new Order(customer2);

        Product product3 = new Product(
            "Mouse",
            "M300",
            15.00,
            3
        );

        Product product4 = new Product(
            "Monitor",
            "MN400",
            150.00,
            1
        );

        Product product5 = new Product(
            "USB Cable",
            "U500",
            8.00,
            2
        );

        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("Order 1");
        Console.WriteLine();

        Console.WriteLine("Packing Label");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine();
        Console.WriteLine("--------------------");
        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine();

        Console.WriteLine("Packing Label");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}