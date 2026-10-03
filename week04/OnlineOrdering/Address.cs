using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

public class Address
{
  private string _street="";
  private string _city="";
  private string _stateOrProvince="";

  private string _country="";
  private bool _IsAddressInUsa;
  


  public Address(string street, string city, string stateOrProvince, string country)
  {
    _street = street;
    _city = city;
    _stateOrProvince = stateOrProvince;
    _country = country;
  }
  public string GetAddress()
    {
        return $"{_street}\n{_city}\n{_stateOrProvince}\n{_country}";
    }
  public bool IsAddressInUsa()
    {  
     return _country == "USA";
   
    }

    
    }
  

 