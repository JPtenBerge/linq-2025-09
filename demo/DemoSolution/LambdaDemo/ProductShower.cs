namespace LambdaDemo;

public class ProductShower
{
	public static List<Product> Products { get; set; } = new()
	{
		new() { Description = "Muis", Price = 4.99M },
		new() { Description = "Toetsenbord", Price = 14.80M },
		new() { Description = "Scherm", Price = 299.99M },
		new() { Description = "Desinfectiespul", Price = 1.50M },
		new() { Description = "Camera", Price = 140M },
		new() { Description = "Meeting Owl Pro", Price = 1400M },
		new() { Description = "Laptop", Price = 2700M },
		new() { Description = "Markeerstift", Price = 0.50M },
	};

	public static void FilterProducts(Predicate<Product> filter, Action<Product> printer)
	{
		foreach (var product in Products)
		{
			if (filter.Invoke(product))
			{
				// Console.WriteLine($"{product.Description} kost {product.Price}");
				printer.Invoke(product);
			}
		}
	}

	public static void FilterDureProducten()
	{
		foreach (var product in Products)
		{
			if (product.Price > 100M)
			{
				Console.WriteLine($"{product.Description} is duur want kost {product.Price}");
			}
		}
	}
	
	public static void FilterProductenBeginnendMet(string letter)
	{
		foreach (var product in Products)
		{
			if (product.Description.StartsWith(letter))
			{
				Console.WriteLine($"{product.Description} begint met {letter}");
			}
		}
	}
}