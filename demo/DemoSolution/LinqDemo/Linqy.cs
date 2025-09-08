namespace LambdaDemo;

public class Linqy
{
	public static List<Product> Products { get; set; } = new()
	{
		new() { Description = "Muis", Price = 4.99M },
		new() { Description = "Toetsenbord", Price = 14.80M },
		new() { Description = "Scherm", Price = 299.99M },
		new() { Description = "Desinfectiespul", Price = 1.50M },
		new() { Description = "Camera", Price = 140M },
		new() { Description = "Meeting Owl Pro", Price = 1400M },
		new() { Description = "Laptop 1", Price = 2700M },
		new() { Description = "Laptop 0", Price = 2100M },
		new() { Description = "Laptop 2", Price = 2700M },
		new() { Description = "Markeerstift", Price = 0.50M },
	};

	public static void Doe()
	{
		var mmmm = Products.SingleOrDefault(x => x.Description.StartsWith("QWERTY"));
		Console.WriteLine(mmmm?.Description);

		foreach (var p in Products.OrderBy(x => x.Price).ThenByDescending(x => x.Description))
		{
			Console.WriteLine($"{p.Description} kost {p.Price}");
		}
	}
}