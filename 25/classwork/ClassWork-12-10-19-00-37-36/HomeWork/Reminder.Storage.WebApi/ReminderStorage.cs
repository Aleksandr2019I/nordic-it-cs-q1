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
			var json = JsonSerializer.Serialize(item);
			var request = new HttpRequestMessage(HttpMethod.Post,"/api/reminders/")
			{ 
				Content = new StringContent(json, Encoding.UTF8,"application/json")
			};

			var response = _client.SendAsync(request)
				.GetAwaiter()
				.GetResult();

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
			
		}
	}
}
