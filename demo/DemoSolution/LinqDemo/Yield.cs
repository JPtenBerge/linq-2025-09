namespace LambdaDemo;

public class Yield
{
	public static void Doe()
	{
		// foreach (var x in GeefWaarden())
		// {
		// 	Console.WriteLine(x);
		// }

		var source = GeefWaarden();
		var enumerator = source.GetEnumerator();
		enumerator.MoveNext();
		enumerator.MoveNext();
		enumerator.MoveNext();
	}


	public static IEnumerable<int> GeefWaarden()
	{
		Console.WriteLine("eerste");
		yield return 4; // deelresultaat
		Console.WriteLine("tweede");
		yield return 8; // deelresultaat
		Console.WriteLine("derde");
		yield return 15; // deelresultaat
		Console.WriteLine("vierde");
		yield return 16; // deelresultaat
		Console.WriteLine("vijfde");
		yield return 23; // deelresultaat
		Console.WriteLine("zesde");
		yield return 42; // deelresultaat
	}
}