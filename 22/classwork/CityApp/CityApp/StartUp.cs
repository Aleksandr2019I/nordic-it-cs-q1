using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace CityApp

{
	public class StartUp
	{
		public void ConfigureServices(IServiceCollection services)
		{		
			services.AddMvc();
		}

		public void Configure(
			IApplicationBuilder builder,
			IHostingEnvironment environment)
		{
			if (environment.EnvironmentName == "local")
			{
				builder.UseDeveloperExceptionPage();
			}
			builder.UseMvc(ConfigureRoutes);
		}

		private static void ConfigureRoutes(IRouteBuilder builder)
		{
			builder.MapRoute(
				name: "Default",
				template: "{controller}/{action}",
				defaults: new { Controller = "City", Action = "List"}
				);
		}
	}
}
