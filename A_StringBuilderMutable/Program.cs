using System.Text;
class Program 
{
	static void Main() {
		StringBuilder a = new("Hello");
		int iteration = 100_000_000;
		
		for(int i = 0;i < iteration;i++) 
		{
			a.Append("World");
			a.Append("!");
			a.Replace("a", "i");
		}
	} 
}