using System;
using L13_C06_interface.Interfaces;

namespace L13_C06_interface.Device
{
	abstract class MusicPlayer: IMusicPlayer, IRestartable
	{
		protected readonly ConsoleWriter _writer;

		public string MusicSource { get; set; }

		protected MusicPlayer(ConsoleWriter writer)
		{
			_writer = writer;
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

		public abstract void Restart();
	}
}
