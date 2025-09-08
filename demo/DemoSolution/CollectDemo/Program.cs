// See https://aka.ms/new-console-template for more information

var dict = new Dictionary<char, int>();

var tekst = "Hallo ik ben JP en ik geef training vandaag";

foreach (var character in tekst.ToLower())
{
	if (dict.ContainsKey(character))
	{
		dict[character]++;
	}
	else
	{
		dict.Add(character, 1);
	}
	
	
	
	
	// IEnumerable<>
	// ICollection<int>
	// IList<int>
	
	// .ForEach()
	
	// IQueryable<T>
}

foreach (var entry in dict.OrderBy(x => x.Key))
{
	Console.WriteLine($"{entry.Key} komt {entry.Value} keer voor");
}

Geef().ToList().ForEach(item => Console.WriteLine(item));



IEnumerable<int> Geef()
{
	throw new NotImplementedException();
}