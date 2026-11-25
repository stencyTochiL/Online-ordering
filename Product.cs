public class Product
{
    private readonly string _name;
    private readonly string _productId;
    private readonly decimal _price;
    private readonly int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("A product name is required.", nameof(name));
        }

        if (string.IsNullOrWhiteSpace(productId))
        {
            throw new ArgumentException("A product ID is required.", nameof(productId));
        }

        if (price < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price));
        }

        if (quantity < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity));
        }

        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabelText()
    {
        return $"{_name} (Product ID: {_productId})";
    }
}
