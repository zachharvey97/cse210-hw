using System;

class Product
  {
    public string _name { get; private set; }
    public string _productId { get; private set; }
    public double _price { get; private set; }
    public double _unitPrice { get; private set; }
    public int _quantity { get; private set; }

    public Product(string name, string productId, double unitPrice, int quantity)
    {
        _name = name;
        _productId = productId;
        _unitPrice = unitPrice;
        _quantity = quantity;

        setPrice();
    }

    private void setPrice()
    {
        _price = _unitPrice * _quantity;
    }
  }