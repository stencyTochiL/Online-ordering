using System.Globalization;

public class Program
{
    public static void Main()
    {
        Address usaAddress = new Address("123 Example Street", "Seattle", "WA", "USA");
        Customer usaCustomer = new Customer("Alex Morgan", usaAddress);
        Order usaOrder = new Order(usaCustomer);
        usaOrder.AddProduct(new Product("Notebook", "NB-101", 4.50m, 2));
        usaOrder.AddProduct(new Product("Pen Pack", "PN-202", 3.00m, 3));

        Address internationalAddress = new Address("14 Sample Road", "Lagos", "Lagos", "Nigeria");
        Customer internationalCustomer = new Customer("Ada Okafor", internationalAddress);
        Order internationalOrder = new Order(internationalCustomer);
        internationalOrder.AddProduct(new Product("Headphones", "HP-303", 25.00m, 1));
        internationalOrder.AddProduct(new Product("USB Cable", "CB-404", 8.00m, 2));

        List<Order> orders = new List<Order> { usaOrder, internationalOrder };

        for (int orderIndex = 0; orderIndex < orders.Count; orderIndex++)
        {
            Order order = orders[orderIndex];
            Console.WriteLine($"ORDER {orderIndex + 1}");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            string totalText = order.GetTotalCost().ToString("C2", CultureInfo.GetCultureInfo("en-US"));
            Console.WriteLine($"Total Cost: {totalText}");
            Console.WriteLine();
        }
    }
}
