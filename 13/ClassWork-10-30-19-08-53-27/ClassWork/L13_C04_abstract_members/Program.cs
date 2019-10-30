using System;
using System.Collections.Generic;
using L13_C04_abstract_members.Device;

namespace L13_C04_abstract_members
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
					MusicSource = "Podcast Server",
					VideoSource = "YouTube"
				}
			};

			foreach (var device in devices)
			{
				consoleWriter.WriteLine($"Class {device.Name}", ConsoleColor.Green);

				device.PlayMusic();
				device.Restart();

				switch(device)
				{
					case MobilePhone phone:
						phone.Call("+7916291XXXX");
						break;
					case RadioRecorder recorder:
						recorder.RecordMusic(TimeSpan.FromSeconds(15));
						break;
					case VideoPlayer player:
						player.PlayVideo();
						break;
					default:
						break;
				}

				consoleWriter.WriteLine("\n");
			}

			consoleWriter.WriteLine("\n\n");
			consoleWriter.ReadKey();
		}
	}
}
