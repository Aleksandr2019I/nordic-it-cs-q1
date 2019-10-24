using System;

namespace CW13
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseDocument proga = new BaseDocument
			{
				Title = "abc",
				Number = "1",
				IssueDate = new DateTimeOffset(new DateTime(2010,11,02)),
			};


			Passport pass = new Passport
			{
				Country = "fllfl",
				PersonName="Multy"

			};

			
		}
	}
}
