public class Address
{
    private readonly string _street;
    private readonly string _city;
    private readonly string _stateProvince;
    private readonly string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        if (string.IsNullOrWhiteSpace(country))
        {
            throw new ArgumentException("A country is required.", nameof(country));
        }

        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country.Trim();
    }

    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase)
            || _country.Equals("US", StringComparison.OrdinalIgnoreCase)
            || _country.Equals("United States", StringComparison.OrdinalIgnoreCase)
            || _country.Equals("United States of America", StringComparison.OrdinalIgnoreCase);
    }

    public string GetDisplayText()
    {
        return $"{_street}{Environment.NewLine}"
            + $"{_city}, {_stateProvince}{Environment.NewLine}"
            + _country;
    }
}
