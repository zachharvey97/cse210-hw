using System;

 class Order
  {
    public List<Product> _products { get; private set; }
    public Customer _customer { get; private set; }
    public double _total { get; private set; }

    public Order(Customer customer, List<Product> products)
    {
        _products = products;
        _customer = customer;

        calcTotalCost();
    }

    public void calcTotalCost()
    {
        double total = 0;
        double shipCost;

        _products.ForEach(product =>
        {
            total += product._price;
         });

        if(_customer.IsInUSA() == true)
        {
            shipCost = 5;
        }
        else
        {
            shipCost = 35;
        }
        
        total += shipCost;

        _total = total;
    }

    private void printPackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine($"Product Name: {product._name}");
            Console.WriteLine($"Product Id: {product._productId}");
            Console.WriteLine();
        }
    }

    private void printShippingLabel()
    {
        Console.WriteLine("*******************\n");
        Console.WriteLine($"Ship to: {_customer._name}");
        _customer._address.printAddress();
        Console.WriteLine();
    }

    public void Display()
    {
        printShippingLabel();
        printPackingLabel();
        Console.WriteLine("*******************");
        Console.WriteLine($"The total cost is: {_total.ToString("0.00")}\n");
    }
  }