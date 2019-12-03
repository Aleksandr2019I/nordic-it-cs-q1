using Microsoft.AspNetCore.Mvc;
using CityApp.ViewModels;
using CityApp.Models;
using CityApp.Servieces;
using System.Linq;
using System;

namespace CityApp.Controllers
{

	/// <summary>
	///  Контроллер, определяет логику по управлению данными городов
	/// </summary>
	public class CityController : Controller
	{
		// GET /cities
		// GET /api/city/list
		[HttpGet("cities", Name = "Get")]
		[HttpGet("api/city/list", Name = "ApiGet")]
		public IActionResult List()
		{
			var cities = CityStorage.Instance
				.GetAll()
				.Select(x => new CityViewModel(x))
				.OrderBy((CityViewModel ViewModel) => ViewModel.Name)
				.ToArray();
			return Ok(cities);
		}

		public IActionResult Get(Guid id)
		{
			if (id == Guid.Empty)
			{
				return BadRequest();
			}

			var city = CityStorage.Instance.GetById(id);

			if (city == null)
			{
				return NotFound();
			}

			return Ok(new DetailCityViewModel(city));
		}
		// POST /cities
		// POST /api/city
		[HttpPost("cities/{id}")]
		[HttpPost("api/city/{id}")]
		public IActionResult Create([FromBody] CreateCityViewModel city)
		{
			if (city == null)
			{
				return BadRequest();
			}

			var model = new City(
				city.Name,
				city.Description,
				city.Population
				);
			CityStorage.Instance.Create(model);
			return CreatedAtAction("Get",model);
		}
	}
}
