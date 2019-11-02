using System;

namespace L14_C14_singleton_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			var singleton =
				SingletonDemo.GetInstance();

			var singleton2 =
				SingletonDemo.GetInstance();

			Console.WriteLine(
				singleton2.Equals(singleton));

			// True
		}
	}
}
