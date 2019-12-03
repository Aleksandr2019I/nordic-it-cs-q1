using CityApp.Models;

namespace CityApp.ViewModels
{
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
}
