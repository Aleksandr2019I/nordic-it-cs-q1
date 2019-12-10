using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Reminder.Storage.WebApi
{
	public class ReminderStorage : IReminderStorage
	{

		private readonly HttpClient _client;
		public ReminderStorage(HttpClient client)
		{
			_client = client;

		}

		public void Add(ReminderItem item)
		{
			
			var response = Execute($"/api/reminders/{item.Id}", HttpMethod.Put, item.ToContent());;

			if (response.StatusCode == HttpStatusCode.Created)
			{
				throw new InvalidOperationException(
					$"Operation failed with code :{response.StatusCode}");
			}
		}

		public List<ReminderItem> FindBy(ReminderItemFilter filter)
		{
			

		}

		public ReminderItem FindById(Guid id)
		{
			
		}

		public void Update(ReminderItem item)
		{
			var content = item.ToContent();
			var response = Execute($"/api/reminders/{item.Id}", HttpMethod.Put, content);

			if (response.StatusCode != HttpStatusCode.Ok)
			{
				throw new InvalidOperationException(
								 $"Operation failed with code :{response.StatusCode}");
			}

		}

		

		private HttpResponseMessage Execute(
			string url,
			HttpMethod method,
			StreamContent content = default)
		{
			var request = new HttpRequestMessage(method,url)
			{
				Content = content
			};
			var response = _client.SendAsync(request)
				.GetAwaiter()
				.GetResult();

			return response;
		}
		public static class Converter
		{
			public static StringContent ToContent<T>(this T item)
			{
				var json = JsonSerializer.Serialize<T>(item);
				return new StringContent(json, Encoding.UTF8, "application/json");
			}
		}
		 
	}
}
