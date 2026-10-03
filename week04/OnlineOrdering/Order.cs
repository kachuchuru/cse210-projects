using System;
using System.Diagnostics.Metrics;
using System.Numerics;

public class Order
{

  private Customer _customer;
  private List<Product>_products;
  
  public Order(Customer customer, List<Product> products)//Constructor
  {
    _customer = customer;
    _products = products;
  }
  public void AddProduct(Product product)
    {
        _products.Add(product);
    }

  public string GetPackingLabel()
{
    string label = $"Customer:{_customer.GetName()}\n";
    foreach (Product product in _products)
        {
            label += $"Product ID:{product.GetProductId()}\n";
            label += $"Product Name:{product.GetProductName()}\n";
        }
        return label;
}
  public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetAddress()}";
    }
 public double GetShippingCost()
    {
        if (_customer.GetAddress().IsAddressInUsa())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

 public double GetTotalCost()
    {
        double total =0;
        foreach (Product product in _products)
        {
            total += product.GetProductCost();
        }
        total += GetShippingCost();
        return total;
    }



     public void Display()
  {
    Console.WriteLine("PACKING LABEL");
    Console.WriteLine(GetPackingLabel());
    Console.WriteLine();
    Console.WriteLine("SHIPPING LABEL");
    Console.WriteLine(GetShippingLabel());
    Console.WriteLine();
    Console.WriteLine($"TOTAL COST: {GetTotalCost()}");
  }
}