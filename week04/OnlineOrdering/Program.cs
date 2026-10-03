using System;

class Program
{
    static void Main(string[] args)
    {
      Address address1 = new Address(
       "Umoja Street",
       "Kinondoni",
       "Dar es salaam",
       "Tanzania"
      );
      Customer customer1 = new 
      Customer("Tundu Lissu", address1); 

      Product product1 = new
      Product("Laptop", "PK01", 800, 1);
      Product product2 = new
      Product("Printer", "PK02", 200, 2);

      List<Product> products1 = new
      List<Product>();
      products1.Add(product1);
      products1.Add(product2);

      Order order1 = new
      Order(customer1, products1);

Address address2 = new Address(
       "50 King Street",
       "Salt Lake City",
       "Utah",
       "USA"
      );
      Customer customer2 = new 
      Customer("Mary Smith", address2); 

      Product product3 = new
      Product("Mouse", "PK03", 10, 1);
      Product product4 = new
      Product("Keyboard", "PK04", 60, 2);

      List<Product> products2 = new
      List<Product>();
      products2.Add(product3);
      products2.Add(product4);

      Order order2 = new
      Order(customer2, products2);

      order1.Display();
      Console.WriteLine();
      order2.Display();








    }
}