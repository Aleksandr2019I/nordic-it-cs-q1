using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityApp.Controllers
{
	//логика по управлению городами
	public class City
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int Population { get; set; }
	}
	public class CityStorage
	{

		private static CityStorage _instance;
		public static CityStorage Instance =>
			_instance ?? (_instance = new CityStorage());

		private readonly List<City> _cities;

		private CityStorage()
		{
			_cities = new List<City>
			{
				new City
				{
					Id = Guid.NewGuid(),
				Name = "Москва",
				Population = 16_000_000
				},
				new City
				{
					Id = Guid.NewGuid(),
				Name = "Санкт Петербург",
				Population = 5_000_000
				},
			};
		}


		public City[] GetAll()
		{
			return _cities.ToArray();
		}


		public void Create(City city)
		{
			_cities.Add(city);

		}
	
	}

	//city/List

	public class CityController : Controller
	{




		[HttpGet("cities")]
		public IActionResult List()
		{

			var cities = CityStorage.Instance.GetAll();
			//var json = Json(cities);
			//return json;
			return Json(cities);
		}

		[HttpPost("api/city")]
		public IActionResult Create([FromBody]City city)
		{
			CityStorage.Instance.Create(city);

			return Ok();
			
		}
	}
}
