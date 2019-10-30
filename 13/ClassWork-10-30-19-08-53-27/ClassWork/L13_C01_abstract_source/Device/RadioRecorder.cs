﻿using System;

namespace L13_C01_abstract_source.Device
{
	class RadioRecorder
	{
		private ConsoleWriter _writer;

		public string MusicSource { get; set; }

		public RadioRecorder(ConsoleWriter writer)
		{
			_writer = writer;
			_writer.WriteLine("Starting work with Radio Recorder", ConsoleColor.Cyan);
		}

		public string RecordingDestination { get; set; }

		public void PlayMusic()
		{
			if (string.IsNullOrEmpty(MusicSource))
			{
				_writer.WriteLine("It is nothing to play. Set the music source and try again.", ConsoleColor.Yellow);
				return;
			}

			_writer.WriteLine($"Playing music from {MusicSource}", ConsoleColor.Yellow);
		}

		public void RecordMusic(TimeSpan duration)
		{
			if (string.IsNullOrEmpty(RecordingDestination))
			{
				_writer.WriteLine(
					"The destination is empty. Set the recording destination and try again.");
				return;
			}

			if (string.IsNullOrEmpty(MusicSource))
			{
				_writer.WriteLine(
					"It is nothing to play. Set the music source and try again.");
				return;
			}

			_writer.WriteLine(
				$"Recording {duration.TotalSeconds} seconds from {MusicSource} to {RecordingDestination}");
		}

		public void Restart()
		{
			_writer.WriteLine("Restarting Radio Recorder... Power Off > Power On.", ConsoleColor.Cyan);
		}
	}
}
