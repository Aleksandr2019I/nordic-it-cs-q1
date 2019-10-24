using System;
namespace CW13
{
	class Passport : BaseDocument
	{
		public string Country { get; set; }
		public string PersonName { get; set; }

		public new string Description =>
			$"{Country},{PersonName}";

		public new void WriteToConsole()
		{
			Console.WriteLine(Description);

		}
	}
}
