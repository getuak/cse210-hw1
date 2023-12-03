using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("123 Newyork St", "Redlands", "CA", "USA");
        Address nonUsaAddress = new Address("W05 bole ", "Addis ababa", "addis ababa", "Ethiopia");


        Customer usCustomer = new Customer("David", usaAddress);
        Customer nonUsCustomer = new Customer("Getu", nonUsaAddress);

        
        Product product1 = new Product("IPhone 15", "IPH15", 1100, 2);
        Product product2 = new Product("Samsung", "PRO121", 1200, 1);

        
        List<Product> order1Products = new List<Product> { product1, product2 };
        Order order1 = new Order(usCustomer, order1Products);

        List<Product> order2Products = new List<Product> { product1, product2 };
        Order order2 = new Order(nonUsCustomer, order2Products);

        Console.WriteLine("order1");
        Console.WriteLine("order2");
    }
}