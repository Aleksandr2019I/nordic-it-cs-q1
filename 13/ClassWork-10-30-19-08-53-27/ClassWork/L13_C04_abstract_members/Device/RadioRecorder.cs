using System;

namespace L13_C04_abstract_members.Device
{
	class RadioRecorder : MusicPlayer
	{
		public string RecordingDestination { get; set; }

		public RadioRecorder(ConsoleWriter writer) : base(writer)
		{
			Writer.WriteLine("Starting work with Radio Recorder", ConsoleColor.Cyan);
		}

		public void RecordMusic(TimeSpan duration)
		{
			if (string.IsNullOrEmpty(RecordingDestination))
			{
				Writer.WriteLine(
					"The destination is empty. Set the recording destination and try again.");
				return;
			}

			if (string.IsNullOrEmpty(MusicSource))
			{
				Writer.WriteLine(
					"It is nothing to play. Set the music source and try again.");
				return;
			}

			Writer.WriteLine(
				$"Recording {duration.TotalSeconds} seconds from {MusicSource} to {RecordingDestination}");
		}

		public override void Restart()
		{
			Writer.WriteLine("Restarting Radio Recorder... Power Off > Power On.", ConsoleColor.Cyan);
		}
	}
}
