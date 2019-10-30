using L13_C02_abstract_class.Device;
using System;

namespace L13_C02_abstract_class
{
	class Program
	{
		static void Main(string[] args)
		{
			var  consoleWriter = new ConsoleWriter();
			consoleWriter.WriteLine("Class MobilePhone\n", ConsoleColor.Green);

			var mobilePhone = new MobilePhone(consoleWriter);
			mobilePhone.Call("+7916291XXXX");
			mobilePhone.MusicSource = "Music in a Social Network";
			mobilePhone.PlayMusic();
			mobilePhone.Restart();

			consoleWriter.WriteLine("\nClass RadioRecorder\n", ConsoleColor.Green);

			var radioRecorder = new RadioRecorder(consoleWriter);
			radioRecorder.MusicSource = "FM Radio Channel";
			radioRecorder.PlayMusic();
			radioRecorder.RecordingDestination = "Flash Drive";
			radioRecorder.RecordMusic(TimeSpan.FromSeconds(15));
			radioRecorder.Restart();

			consoleWriter.WriteLine("\nClass VideoPlayer\n", ConsoleColor.Green);

			var videoPlayer = new VideoPlayer(consoleWriter)
			{
				VideoSource = "YouTube"
			};
			videoPlayer.PlayVideo();
			videoPlayer.PlayMusic();
			videoPlayer.MusicSource = "Podcast Server";
			videoPlayer.PlayMusic();
			videoPlayer.Restart();

			consoleWriter.WriteLine("\n\n");
			consoleWriter.ReadKey();
		}
	}
}
