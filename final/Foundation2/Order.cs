class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order()
    {
        _products = new List<Product>();
        _customer = new Customer();
    }
    public void AddProduct(string name, string productID, double price, int quantity)
    {
        Product product = new Product(name, productID, price, quantity);
        _products.Add(product);
    }
    public void AddCustomer(string name, string street, string city, string state, string country)
    {
        _customer.SetName(name);
        _customer.CreateNewAddress(street, city, state, country);
    }
    public void CalcCost()
    {
        double cost = 0;
        foreach(Product product in _products)
        {
            cost += product.TotalCost();
        }
        if (_customer.IfUSa() == true)
        {
            cost += 5;
            Console.WriteLine("There is 5$ added for shipping");
        }
        else
        {
            cost += 35;
            Console.WriteLine("There is 35$ added for shipping");
        }
        Console.WriteLine($"The total cost is ${cost}");
    }

    public void PackingLabel()
    {
        Console.WriteLine("Products: ");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Name: {product.GetName()}: ID: {product.GetProductID()} ");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("Customer: ");
        Console.WriteLine($"Name: {_customer.GetName()}, Address: {_customer.AddressString()} ");
    }

}