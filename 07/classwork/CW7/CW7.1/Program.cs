using System;
using System.Text;
namespace CW7._1
{
	class Program
	{
		static void Main(string[] args)
		{

			/*var words = text.Split(' ',StringSplitOptions.RemoveEmptyEntries);
			result = words[1].ToUpper;

			Console.WriteLine(string.Join(" ", words));


			var results = new string[words.Length];
			for (int i = 0; i < results.Length; i++)
			{
				results[i]
			}

			

			Console.WriteLine($"{textstr}");
			Console.WriteLine($"{up}");
			*/
			string text = "   lorem   ipsun   dolor     sit   amet  ";
			StringBuilder sb = new StringBuilder(text);
			sb.Remove (0);

			Console.WriteLine($"{sb}");
			Console.ReadKey();
		}
	}
}
