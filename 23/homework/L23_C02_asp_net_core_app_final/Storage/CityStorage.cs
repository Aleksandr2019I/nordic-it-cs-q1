﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace L23_C02_asp_net_core_app_final.Storage
{
    /// <summary>
    /// Cities in memory storage
    /// </summary>
    public class CityStorage : ICityStorage
    {
        private readonly List<City> _cities;

        public CityStorage()
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
        /// Returns all cities ordered by name
        /// </summary>
        public City[] GetAll()
        {
            return _cities
                .OrderBy(_ => _.Name)
                .ToArray();
        }

        /// <summary>
        /// Returns single city by specified identity or returns null
        /// </summary>
        public City GetById(Guid id)
        {
            return _cities.FirstOrDefault(_ => _.Id == id);
        }

        /// <summary>
        /// Finds single city by specified name or returns null
        /// </summary>
        public City FindByName(string name)
        {
            return _cities.FirstOrDefault(_ => string.Equals(_.Name, name?.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Adds new city element 
        /// </summary>
        public void Create(City city)
        {
            _cities.Add(city);
        }

        /// <summary>
        /// Дома
        /// Метод замены в коллекции
        /// </summary>
        public void Put(City city)
        {
            _cities.Remove(city);
            _cities.Add(city);
        }
        /// <summary>
        /// дома
        /// Метод удаления в коллекции
        /// </summary>
        public void Delete(City city)
        {
            _cities.Remove(city);
        }
    }
}
