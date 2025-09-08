using AnonTypeDemo; 
	
Console.WriteLine("Hello, World!");

var getal = 14;
// getal = "qwer";

// var dingen = [];
// "the lazy keyword"
// IEnumerable<Product> lijst;

var tekst = "hoi";

var anoniemObject = new
{
	Hoi = "iets",
	Getal = 184
};

// waar gebruiken we die?
// - testen
// - samenvoegen van parameters
// - configuratie <== voornaamste

// modelBuilder.Entity<Product>().HasKey(x => new { x.ProductId, x.CategoryId });
// LINQ: .Select(x => new { x.Ding, x.Hoi })

var nu = DateTime.Now;
Console.WriteLine(nu.ToString("dd-MM-yyyy"));
Console.WriteLine(nu.ToPrettyString());

// wrapper class?
// mappings  .ToEntity() .ToDto()
// libraries: FluentAssertions  Flurl
// ASP.NET Core

// app.MapRazorPages();
// app.MapSignalRHUb();

// actual.Should().BeEquivalentTo(expected);

// dynamic qwert = null!;
// qwert.Doe(14, "hoi");

// COM-objecten









