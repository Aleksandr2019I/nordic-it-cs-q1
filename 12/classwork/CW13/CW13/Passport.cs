using System;
namespace CW13
{
	class Passport : BaseDocument
	{
		public Passport(string country, string personName,string number, DateTimeOffset issueDate) :
			base (title :"Passport",number: number, issueDate: issueDate)
		{
			Country = country;
			PersonName = personName;
		}

		public string Country { get; set; }
		public string PersonName { get; set; }

		public override string Description =>
			$"{Country},{PersonName}";



		//public new void WriteToConsole()
		//{
		//	Console.WriteLine(Description);

		//}
	}
}
