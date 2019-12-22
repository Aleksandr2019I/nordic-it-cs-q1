using System;
using Microsoft.AspNetCore.Mvc;

namespace CityApp.Controllers
{
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
