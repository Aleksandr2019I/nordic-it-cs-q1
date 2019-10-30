using System;

namespace L13_C01_abstract_source.Device
{
	class MobilePhone
	{
		private ConsoleWriter _writer;

		public string MusicSource { get; set; }

		public MobilePhone(ConsoleWriter writer)
		{
			_writer = writer;
			_writer.WriteLine("Starting work with Mobile Phone", ConsoleColor.Cyan);
		}

		public void PlayMusic()
		{
			if (string.IsNullOrEmpty(MusicSource))
			{
				_writer.WriteLine("It is nothing to play. Set the music source and try again.", ConsoleColor.Yellow);
				return;
			}

			_writer.WriteLine($"Playing music from {MusicSource}", ConsoleColor.Yellow);
		}

		public void Call(string phoneNumber)
		{
			_writer.WriteLine($"Calling {phoneNumber}...");
		}

		public void Restart()
		{
			_writer.WriteLine("Restarting Mobile Phone... Displaying splash screen while loading.", ConsoleColor.Cyan);
		}
	}
}
