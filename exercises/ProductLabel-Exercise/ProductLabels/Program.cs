using ProductLabels.Entities;

Console.Write("Enter the number of product: ");
int quantProducts = int.Parse(Console.ReadLine());
List <Product> products = new List<Product>();
for (int i = 1;  i <= quantProducts; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common used or imported (c/u/i)?: ");
    char opt = char.Parse(Console.ReadLine());
    if (opt == 'c')
    {
        Console.Write("Name: ");
        string productName = Console.ReadLine();
        Console.Write("Price: ");
        double productPrice = double.Parse(Console.ReadLine());
        products.Add(new Product(productName, productPrice));
    }
    else if (opt == 'i')
    {
        Console.Write("Name: ");
        string productName = Console.ReadLine();
        Console.Write("Price: ");
        double productPrice = double.Parse(Console.ReadLine());
        Console.Write("Customs fee: ");
        double productCustomsFee = double.Parse(Console.ReadLine());
        products.Add(new ImportedProduct(productName, productPrice, productCustomsFee));
    }
    else
    {
        Console.Write("Name: ");
        string productName = Console.ReadLine();
        Console.Write("Price: ");
        double productPrice = double.Parse(Console.ReadLine());
        Console.Write("Manufactured date (DD/MM/YYY): ");
        DateTime productManufacturedDate = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct(productName, productPrice, productManufacturedDate));
    }
}

Console.WriteLine("PRICE TAGS: ");

foreach(Product product in products)
{
    Console.WriteLine(product.priceTag());
}