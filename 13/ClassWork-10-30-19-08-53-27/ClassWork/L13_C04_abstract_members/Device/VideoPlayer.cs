using System;

namespace L13_C04_abstract_members.Device
{
	class VideoPlayer : MusicPlayer
	{
		public string VideoSource { get; set; }

		public VideoPlayer(ConsoleWriter writer) : base(writer)
		{
			Writer.WriteLine("Starting work with Video Player", ConsoleColor.Cyan);
		}

		public void PlayVideo()
		{
			if (string.IsNullOrEmpty(VideoSource))
			{
				Writer.WriteLine("It is nothing to play. Set the video source and try again.");
				return;
			}

			Writer.WriteLine($"Playing video from {VideoSource}");
		}

		public override void Restart()
		{
			Writer.WriteLine("Restarting Video Player... Please wait about 10 seconds.", ConsoleColor.Cyan);
		}
	}
}
