using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CW21
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateWebHostBuilder(args).Build().Run();
		}
		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup2>();
	}
	public class Startup2
	{
		public void Configure(IApplicationBuilder builder,IHostingEnvironment environment)
		{
			if (environment.IsDevelopment())
			{
				builder.UseDeveloperExceptionPage();
			}
			builder.Use(PostWorldRequest);
			builder.Use(GetHelloRequest);
			builder.Run(GetAllRequest);
		}
		//post/world
		private static Task PostWorldRequest(HttpContext context,Func<Task> next)
		{
			if (context.Request.Method.ToUpper() == "POST" && 
				context.Request.Path.StartsWithSegments("/world"))
			{
				context.Response.StatusCode = 201;
				return context.Response.WriteAsync("POST Hello World");
			}
			return next();
		}
		//get//hello
		private static Task GetHelloRequest(HttpContext context, Func<Task> next)
		{
			if (context.Request.Method.ToUpper() == "GET" && 
				context.Request.Path.StartsWithSegments("/Hello"))
			{
				context.Response.StatusCode = 200;
				return context.Response.WriteAsync("Get Hello World"); ;
			}
			return next();
		}
		//* *
		private static Task GetAllRequest(HttpContext context)
		{
			throw new Exception("some");
		}
	}
}
