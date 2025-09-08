// See https://aka.ms/new-console-template for more information

using LambdaDemo;

ProductShower.FilterDureProducten();
ProductShower.FilterProductenBeginnendMet("M");


// 3 delegates:
// - Action<T> - geen returnwaarde
// - Predicate<T> - altijd een boolean als returnwaarde
// - Func<T, bool> - instelbare returnwaarde

Console.WriteLine("==============");
Predicate<Product> duurPred = delegate(Product p) { return p.Price > 50; };
Predicate<Product> duurPred2 = p => p.Price > 50;

// ProductShower.FilterProducts(duurPred);
// ProductShower.FilterProducts(duurPred2);
ProductShower.FilterProducts(p => p.Price > 50, p => Console.WriteLine($"Product hier is duur: {p.Description}"));

Parallel.Invoke(
	() => Console.WriteLine("bla"),
	() => Console.WriteLine("bla"),
	() => Console.WriteLine("bla"),
	() => Console.WriteLine("bla"),
	() => Console.WriteLine("bla")
);

