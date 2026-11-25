public class Customer
{
    private readonly string _name;
    private readonly Address _address;

    public Customer(string name, Address address)
    {
        ArgumentNullException.ThrowIfNull(address);
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetAddressText()
    {
        return _address.GetDisplayText();
    }
}
