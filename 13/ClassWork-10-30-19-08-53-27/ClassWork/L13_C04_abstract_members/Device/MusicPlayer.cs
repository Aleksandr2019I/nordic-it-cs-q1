using System;

namespace L13_C04_abstract_members.Device
{
	abstract class MusicPlayer
	{
		protected readonly ConsoleWriter Writer;

		public string MusicSource { get; set; }

		public string Name =>
			GetType().Name;

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
