using System;
using System.Collections.Generic;
using L13_C06_interface.Device;
using L13_C06_interface.Interfaces;

namespace L13_C06_interface
{
	class Program
	{
		static void Main(string[] args)
		{
			var consoleWriter = new ConsoleWriter();
			var devices = new MusicPlayer[]
			{
				new MobilePhone(consoleWriter)
				{
					MusicSource = "Music in a Social Network"
				},
				new RadioRecorder(consoleWriter)
				{
					MusicSource = "FM Radio Channel",
					RecordingDestination = "Flash Drive"
				},
				new VideoPlayer(consoleWriter)
				{
					VideoSource = "YouTube",
					MusicSource = "Podcast Server"
				}
			};

			Execute(devices, consoleWriter);
		}

		private static void Execute(IEnumerable<MusicPlayer> devices, ConsoleWriter writer)
		{
			foreach (var device in devices)
			{
				writer.WriteLine(device.Name, ConsoleColor.Green);

				if (!string.IsNullOrEmpty(player.MusicSource))
				{
					player.PlayMusic();
					player.Restart();
				}

				if (device is IVideoPlayer player)
				{
					player.PlayVideo();
				}
				if (device is IMusicRecorder recorder)
				{
					recorder.RecordMusic(TimeSpan.FromMinutes(20));
				}
				if (device is ICaller caller)
				{
					caller.Call("+7916291XXXX");
				}
				if (device is IRestartable restartable)
				{
					restartable.Restart();
				}
			}

			writer.ReadKey();
		}
	}
}