using System;
using System.Diagnostics.Metrics;
using System.Numerics;

public class Product
{

  private string _productName="";
  private string _productId="";
  private int _price;

  private int _quantity;
  

  public string GetProductId()
  {
    return _productId;
  }
  public string GetProductName()
    {
        return _productName;
    }
  public Product(string productName, string productId, int price, int quantity)
  {
    _productName = productName;
    _productId= productId;
    _price = price;
    _quantity= quantity;
  }

 public double GetProductCost()
    {
        return _quantity * _price;
    }

}