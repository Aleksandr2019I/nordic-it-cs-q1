using System;
using L13_C06_interface.Interfaces;

namespace L13_C06_interface.Device
{
	class VideoPlayer : MusicPlayer, IVideoPlayer, IMusicPlayer, IRestartable
	{
		public string VideoSource { get; set; }

		public VideoPlayer(ConsoleWriter writer) : base(writer)
		{
			_writer.WriteLine("Starting work with Video Player", ConsoleColor.Cyan);
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

		public override void Restart()
		{
			_writer.WriteLine("Restarting Video Player... Please wait about 10 seconds.", ConsoleColor.Cyan);
		}
	}
}
