using System;

namespace L10_C00_class_encapsulation
{
	class Program
	{
		// array of strings - command line arguments specified to program
		static void Main(string[] args)
		{
			DisplayText($"Specified command line arguments is : {string.Join(", ", args)}");

			if (args.Length > 0 && args[0] == "status")
			{
				DisplayText("The execution of status command");
			}

			// Method overrides invocation
			DisplayText();
			DisplayText("the string b");
			DisplayText(ReadInteger().ToString());
			DisplayText("{0} {1} {2} {3}", 1, 2, 3, 4);
			DisplayText("{0} {1} {2} {3}", new object[] { 1, 2, 3, 4 });

			// The wallet example
			Wallet wallet = new Wallet();

			// Will throw if negative value specified
			Wallet wallet1 = new Wallet(1000m);

			// Will throw if negative or empty value specified, with different errors
			Wallet wallet2 = new Wallet(1000m, "Skin", "Person");
		}

		static void DisplayText()
		{
			// use local variable to display text
			var text = "Some text";
			Console.WriteLine(text);
		}

		// override DisplayText method 
		static void DisplayText(string text)
		{
			Console.WriteLine(text);
		}

		// override DisplayText method 
		static void DisplayText(string first, string second)
		{
			// Any string interpolation will be converted to string.Format method by C# compiler
			Console.WriteLine("{0} {1}", first, second);
			Console.WriteLine($"{first} {second}");
			Console.WriteLine(string.Format("{0} {1}", first, second));
		}

		// override DisplayText method 
		static void DisplayText(string first, int second)
		{
		}

		// override DisplayText method 
		static void DisplayText(string format, params object[] args)
		{
			Console.WriteLine(format, args);

			// With params modifier array of arguments will be created by compiler
			Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", 1, 2, 3, 4, 5, 6, 7, 8);
			Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", new object[] { 1, 2, 3, 4, 5, 6, 7, 8 });
		}

		// Returns integer value
		static int ReadInteger()
		{
			var a = 42;
			return a;
		}
	}
}

