using System;

namespace L13_C01_abstract_source.Device
{
	class VideoPlayer
	{
		private ConsoleWriter _writer;

		public string MusicSource { get; set; }

		public string VideoSource { get; set; }

		public VideoPlayer(ConsoleWriter writer)
		{
			_writer = writer;
			_writer.WriteLine("Starting work with Video Player", ConsoleColor.Cyan);
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

		public void PlayVideo()
		{
			if (string.IsNullOrEmpty(VideoSource))
			{
				_writer.WriteLine("It is nothing to play. Set the video source and try again.");
				return;
			}

			_writer.WriteLine($"Playing video from {VideoSource}");
		}

		public void Restart()
		{
			_writer.WriteLine("Restarting Video Player... Please wait about 10 seconds.", ConsoleColor.Cyan);
		}
	}
}
