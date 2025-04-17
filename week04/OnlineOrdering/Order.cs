using System;

public class Order
{
    private List<Tuple<Products, Customer>> _customerPurchases;
    private string _packingLabel;
    private string _shippingLabel;

    public Order()
    {
        _customerPurchases = new List<Tuple<Products, Customer>>();
    }

    public float GetTotalCost()
    {
        float totalCost = 0;
        foreach (var item in _customerPurchases)
        {
            totalCost += item.Item1.Price;
        }
        return totalCost;
    }

    public void AddProductToOrder(Products product, Customer customer)
    {
        _customerPurchases.Add(new Tuple<Products, Customer>(product, customer));
    }

    public void Display()
    {
        foreach (var item in _customerPurchases)
        {
            Console.WriteLine($"Product: {item.Item1.Name}, Customer: {item.Item2.Name}, Price: ${item.Item1.Price}");
        }
        Console.WriteLine($"Total Cost: ${GetTotalCost()}");
        Console.WriteLine($"Packing Label: {_packingLabel}");
        Console.WriteLine($"Shipping Label: {_shippingLabel}");
    }

    public string PackingLabel
    {
        get { return _packingLabel; }
        set { _packingLabel = value; }
    }

    public string ShippingLabel
    {
        get { return _shippingLabel; }
        set { _shippingLabel = value; }
    }
}