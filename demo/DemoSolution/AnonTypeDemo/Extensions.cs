namespace AnonTypeDemo;

public static class Extensions
{
	public static string ToPrettyString(this DateTime datum)
	{
		return datum.ToString("dd-MM-yyyy");
	}
}