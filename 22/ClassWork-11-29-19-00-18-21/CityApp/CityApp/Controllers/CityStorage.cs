using System;
using System.Collections.Generic;

namespace CityApp.Controllers
{
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
            var temp = _cities.Find(x => x.Id == id);
            temp.Name = city.Name;
            temp.Population = city.Population;

        }
        /// <summary>
        /// дома
        /// Метод удаления в коллекции
        /// </summary>
        public void Delete(Guid id)
        {
           var temp = _cities.Find(x => x.Id == id);
            _cities.Remove(temp);
            
                }
    }
}
