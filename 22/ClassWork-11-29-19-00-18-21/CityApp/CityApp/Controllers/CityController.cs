﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CityApp.Controllers
{
	public class City
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int Population { get; set; }
	}

	/// <summary>
	/// Хранилище городов
	/// </summary>
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
				}
			};
		}

		/// <summary>
		/// Метод возвращает список всех городов
		/// </summary>
		public City[] GetAll()
		{
			return _cities.ToArray();
		}

		/// <summary>
		/// Метод добавляет город в коллекцию 
		/// </summary>
		public void Create(City city)
		{
			_cities.Add(city);
		}
		/// <summary>
		/// ///////////
		/// </summary>
		/// <param name="city"></param>
		public void Put(City city)
		{

			_cities.Remove(city);

			_cities.Add(city);
			
		}

		public void Delete(City city)
		{
			_cities.Remove(city);
		}

	}

	/// <summary>
	///  Контроллер, определяет логику по управлению данными городов
	/// </summary>
	public class CityController : Controller
	{
		// GET /cities
		// GET /api/city/list
		[HttpGet("cities")]
		[HttpGet("api/city/list")]
		public IActionResult List()
		{
			var cities = CityStorage.Instance.GetAll();
			return Json(cities);
		}

		// POST /cities
		// POST /api/city
		[HttpPost("cities")]
		[HttpPost("api/city")]
		public IActionResult Create([FromBody] City city)
		{
			CityStorage.Instance.Create(city);
			return Ok();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="city"></param>
		/// <returns></returns>
		[HttpPut("cities")]
		[HttpPut("api/city/list")]
		public IActionResult Put([FromBody] City city)
		{
			CityStorage.Instance.Put(city);
			return Ok();

		}
		[HttpDelete("cities")]
		[HttpDelete("api/city/list")]
		public IActionResult Delete([FromBody]City city )
		{
			CityStorage.Instance.Delete(city);
			return Ok();

		}

	}
}
