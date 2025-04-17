using System;
public class Products
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    public Products(string name, int productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int ProductId
    {
        get { return _productId; }
        set { _productId = value; }
    }

    public float Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

     public void Display()
    {
        Console.WriteLine($"Product ID: {_productId}");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Price: ${_price}");
        Console.WriteLine($"Quantity: {_quantity}");
    }
}