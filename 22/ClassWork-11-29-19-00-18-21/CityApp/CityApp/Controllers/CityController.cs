using System;
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
        /// Дома
        /// Метод замены в коллекции
        /// </summary>
        public void Put(Guid id,City city)
        {
            var x = _cities.Find(x => x.Id == id);
            x.Name = city.Name;
            x.Population = city.Population;

        }
        /// <summary>
        /// дома
        /// Метод удаления в коллекции
        /// </summary>
        public void Delete(Guid id)
        {
           var fe = _cities.Find(x => x.Id == id);
            _cities.Remove(fe);
            
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

        //дома
        [HttpPut("cities")]
        [HttpPut("api/city/{id}")]
        public IActionResult Put([FromBody]Guid id, City city)
        {
            if (id == default)
            {
                return BadRequest();
            }
            if (city == null)
            {
                return BadRequest();
            }

            CityStorage.Instance.Put(id,city);
            return Ok();
        }
        //дома
        [HttpDelete("cities")]
        [HttpDelete("api/city/{id}")]
        public IActionResult Delete([FromQuery]Guid id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            CityStorage.Instance.Delete(id);
            return Ok();
        }
    }
}
