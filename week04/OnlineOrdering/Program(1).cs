using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("4203 Cedar Cir", "Southwick", "Iowa", "USA");
        Address address2 = new Address("108 Farm Dr", "Montreal", "Quebec", "Canada");

        Products product1 = new Products("Rocking Chair", 101, 399.99f, 3);
        Products product2 = new Products("Coffee Table", 102, 199.99f, 2);
        Products product3 = new Products("Lamp", 103, 49.99f, 4);
        Products product4 = new Products("Sofa", 104, 999.99f, 1);

        Customer customer1 = new Customer("Maggie Perkins", address1);
        Customer customer2 = new Customer("Doug Fisher", address2);

        Order order1 = new Order();
        Order order2 = new Order();

        order1.AddProductToOrder(product1, customer1);
        order1.AddProductToOrder(product2, customer1);

        order2.AddProductToOrder(product3, customer2);
        order2.AddProductToOrder(product4, customer2);

        order1.PackingLabel = "Handle with care";
        order1.ShippingLabel = $"Ship to: {customer1.Name}\n{customer1.Address.FullAddress()}";  

        order2.PackingLabel = "Fragile";
        order2.ShippingLabel = $"Ship to: {customer2.Name}\n{customer2.Address.FullAddress()}";  

        Console.WriteLine("Order 1 Details:");
        order1.Display();
        Console.WriteLine("\nOrder 2 Details:");
        order2.Display();
    
    }
}