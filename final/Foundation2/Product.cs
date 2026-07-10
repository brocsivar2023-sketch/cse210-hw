class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;
    public Product()
    {
        _name = " ";
        _productId = " ";
        _price = 0;
        _quantity = 0;
    }
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public string GetProductID()
    {
        return _productId;
    }
    public string GetName()
    {
        return _name;
    }
    public double TotalCost()
    {
        return _price * _quantity;
    }
}