using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        

        Address adddres1 = new Address("lwansunu","Kampala","Central","Uganda");

        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");



        Customer customer1 = new Customer("Bonny", address1);
        Customer customer2 = new Customer("Bright", address2);


         Product product1 = new Product("bulb", "H468", 13.99f, 2);
        Product product2 = new Product("phone", "G456", 1034.99f, 1);
        Product product3 = new Product("keyboard", "Y789", 525.99f, 3);


        //Order DisplayOrderDetails = new Order()


        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
        Order order2 = new Order(new List<Product> { product3 }, customer2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotal()}");
        Console.WriteLine($"Total Cost: ${order2.GetTotal()}");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order2.GetShippingLabel());

        
        //DisplayOrderDetails(order1);
        //DisplayOrderDetails(order2);




        
        //order1._cu

        //Customer customer1 = new Customer();






    }
}