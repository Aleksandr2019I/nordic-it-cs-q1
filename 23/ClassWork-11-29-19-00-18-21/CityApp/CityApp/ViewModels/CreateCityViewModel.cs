using CityApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityApp.ViewModels
{
	public class CreateCityViewModel
	{
		public string Name { get; set; }
		public int Population { get; set; }
		public string Description { get; set; }
	}

	public class CityViewModel
	{
		public string Id { get; set; }
		public string Name { get; set; }

		public CityViewModel(City city)
		{
			Id = city.Id.ToString("N");
			Name = city.Name;

		}

		public CityViewModel()
		{
		}
	}

	public class DetailCityViewModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public int Population { get; set; }
		public string Description { get; set; }

		public DetailCityViewModel(City city)
		{
			Id = city.Id.ToString("N");
			Name = city.Name;
			Description = city.Description;
			Population = city.Population;

		}

		public DetailCityViewModel()
		{
		}
	}
}
