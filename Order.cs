public class Order
{
    private readonly List<Product> _products;
    private readonly Customer _customer;

    public Order(Customer customer)
    {
        ArgumentNullException.ThrowIfNull(customer);
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        ArgumentNullException.ThrowIfNull(product);
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0m;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        // Shipping is charged once for the order, not once per product.
        decimal shippingCost = _customer.IsInUSA() ? 5m : 35m;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        List<string> productLines = new List<string>();

        foreach (Product product in _products)
        {
            productLines.Add(product.GetPackingLabelText());
        }

        return string.Join(Environment.NewLine, productLines);
    }

    public string GetShippingLabel()
    {
        return _customer.GetName() + Environment.NewLine
            + _customer.GetAddressText();
    }
}
