using System;

namespace L14_C03_interface_IDisposable_using_SW
{
	class Program
	{
		private static void Main()
		{
			using (var errorList = new ErrorList("Program Errors"))
			{
				errorList.Errors.Add("I/O error");
				errorList.Errors.Add("Some unknown error");

				foreach (var error in errorList.Errors)
				{
					Console.WriteLine(errorList.Category + ": " + error);
				}
			}
		}
	}
}
