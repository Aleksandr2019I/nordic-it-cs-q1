using System;
using System.Collections.Generic;
namespace CW14
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ErrorList errorList = new ErrorList("ошибка",new List<string>()))
			{
				errorList.Add("onex");
				errorList.Add("Twox");


				foreach (var item in errorList)
				{
					Console.WriteLine($"{item}");
				}
			}


			Console.ReadKey();
		}
	}
}
