namespace AnonTypeDemo;

public class Tuples
{
	// functie met meerdere outputs

	public static void Doe()
	{
		var tuple = new Tuple<int, string, double>(14, "hpo", 253d);

		var betereTuple = (14, "hoi", 194m);


		var (getal, tekst, nogEenGetal) = GeefWaarden();
		
		// stack en heap
	}

	public static (int, string, double) GeefWaarden()
	{
		return (14, "hoi", 384d);
	}
	
	// public static MijnObject GeefWaarden2()
	// {
	// 	return new MijnObject() { ... };
	// }
}