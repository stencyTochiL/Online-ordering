# Online Ordering

CSE 210 Foundation Program 2: Encapsulation with Online Ordering.

## Run

With the .NET 8 SDK (or a compatible newer SDK) installed, extract this folder, open it in VS Code, and run the following in the folder containing OnlineOrdering.csproj:

```sh
dotnet run
```

No menu or user input is required. Main creates two orders and displays their packing labels, shipping labels, and totals in US dollars.

## Classes

Each class has its own matching file. All member variables are private and use _underscoreCamelCase. Classes and methods use TitleCase; local variables use camelCase.

- Product.cs stores a name, product ID, unit price, and quantity. GetTotalCost calculates unit price multiplied by quantity. GetPackingLabelText returns its name and ID.
- Address.cs stores a street, city, state/province, and country. It formats the address and determines whether it is in the USA.
- Customer.cs contains a name and an Address object. Its country check and address display delegate to the Address object.
- Order.cs contains a Customer object and a private list of Product objects. It calculates total cost and creates packing and shipping labels.
- Program.cs creates and displays two orders, each with two products and a customer containing an address.

Shipping is charged once per order: $5 for USA customers, $35 for other customers. Money uses decimal to preserve dollars and cents. A packing label contains every product name and ID; a shipping label contains the customer name and complete address.

## Expected totals

Order 1: (2 x $4.50) + (3 x $3.00) + $5 shipping = $23.00.
Order 2: (1 x $25.00) + (2 x $8.00) + $35 shipping = $76.00.

## Submission

Copy the five .cs files into your course repository's week04/OnlineOrdering project. If that folder already has a project file, keep the course project configuration and replace its sample Program.cs to avoid duplicate Main methods. Otherwise use the included OnlineOrdering.csproj.

Run the program in VS Code, capture your actual program execution if required by your course instructions, and add the screenshot alongside the source files in GitHub. Submit the repository link in Canvas. Extract the ZIP before uploading source files to GitHub.

## Validation performed

Compiled with .NET SDK 8.0.428: zero warnings and zero errors. The program was executed and its actual output is in sample-output.txt. Thirteen checks passed, covering product quantities, domestic and international shipping, repeated cost calls, label contents, USA country matching, and private member fields.
