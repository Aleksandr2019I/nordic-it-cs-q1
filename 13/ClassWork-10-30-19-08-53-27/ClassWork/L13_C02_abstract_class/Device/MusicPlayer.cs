using System;

namespace L13_C02_abstract_class.Device
{
	abstract class MusicPlayer
	{
		protected readonly ConsoleWriter Writer;

		public string MusicSource { get; set; }

		protected MusicPlayer(ConsoleWriter writer)
		{
			Writer = writer;
		}

		public void PlayMusic()
		{
			if (string.IsNullOrEmpty(MusicSource))
			{
				Writer.WriteLine("It is nothing to play. Set the music source and try again.", ConsoleColor.Yellow);
				return;
			}

			Writer.WriteLine($"Playing music from {MusicSource}", ConsoleColor.Yellow);
		}

    public abstract void Restart();
	}
}
