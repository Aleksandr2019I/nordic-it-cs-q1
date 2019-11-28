using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
namespace CityApp
{
	public class Program
	{
		private static void Main(string[] args)
		{
			BuilWebHostBuilder(args)
				.Build()
				.Run();

			Console.ReadKey();
		}

		private static IWebHostBuilder BuilWebHostBuilder(string[] args)
		{

			return WebHost
				.CreateDefaultBuilder()
				.UseStartup<StartUp>();
		}
	}

}
