using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace CityApp
{
	public class Program
	{
		private static void Main(string[] args)
		{
			var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

			try
			{
				BuildWebHostBuilder(args)
				.Build()
				.Run(); 
			}
			catch (Exception ex)
			{
				//NLog: catch setup errors
				logger.Error(ex, "Stopped program because of exception");
				throw;
			}
			finally
			{
				// Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
				NLog.LogManager.Shutdown();
			}

			Console.ReadKey();
		}

		private static IWebHostBuilder BuildWebHostBuilder(string[] args)
		{
			return WebHost
				.CreateDefaultBuilder()
				.ConfigureLogging(builder =>
					builder.ClearProviders()		
					)
				.UseStartup<Startup>()
				.UseNLog();
		}
	}
}
