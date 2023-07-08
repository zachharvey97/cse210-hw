using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("570 S 2nd St W", "Rexburg", "Idaho", "USA");
        Address address2 = new Address("47 Burnt Swamp Rd", "Wrentham", "Massachusetts", "USA");
        Address address3 = new Address("1 Chome 6-1 Oyachinishi", "Sapporo", "Hokkaido", "Japan");

        Customer customer1 = new Customer("Johnny Boss", address1);
        Customer customer2 = new Customer("Ken Harvey", address2);
        Customer customer3 = new Customer("Hiro Akamatsu", address3);

        Product p1 = new Product("Game Cube Controller", "Nin16", 19.99, 2);
        Product p2 = new Product("A/C Unit", "ge345", 349.99, 1);
        Product p3 = new Product("Hand Towel", "tw534", 3.99, 8);

        Product p4 = new Product("Pizza Stone", "pza76", 39.99, 1);
        Product p5 = new Product("Pizza cutter", "pza94", 9.99, 3);
        Product p6 = new Product("70 inch TV", "dh34", 499.99, 2);

        Product p7 = new Product("Planner", "jnl26", 5.99, 25);
        Product p8 = new Product("Bicycle", "mtnbk22", 249.99, 1);
        Product p9 = new Product("Chopsticks (10)", "cps534", 7.99, 30);

        List<Product> products1 = new List<Product>();
        List<Product> products2 = new List<Product>();
        List<Product> products3 = new List<Product>();

        products1.Add(p1);
        products1.Add(p2);
        products1.Add(p3);

        products2.Add(p4);
        products2.Add(p5);
        products2.Add(p6);

        products3.Add(p7);
        products3.Add(p8);
        products3.Add(p9);

        Order order1 = new Order(customer1, products1);
        Order order2 = new Order(customer2, products2);
        Order order3 = new Order(customer3, products3);

        order1.Display();
        order2.Display();
        order3.Display();
    }
}