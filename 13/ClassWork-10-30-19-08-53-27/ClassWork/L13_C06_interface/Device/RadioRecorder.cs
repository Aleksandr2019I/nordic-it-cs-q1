using System;
using L13_C06_interface.Interfaces;

namespace L13_C06_interface.Device
{
	class RadioRecorder : MusicPlayer, IMusicRecorder, IMusicPlayer, IRestartable
	{
		public string RecordingDestination { get; set; }

		public RadioRecorder(ConsoleWriter writer) : base(writer)
		{
			_writer.WriteLine("Starting work with Radio Recorder", ConsoleColor.Cyan);
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

		public override void Restart()
		{
			_writer.WriteLine("Restarting Radio Recorder... Power Off > Power On.", ConsoleColor.Cyan);
		}
	}
}
