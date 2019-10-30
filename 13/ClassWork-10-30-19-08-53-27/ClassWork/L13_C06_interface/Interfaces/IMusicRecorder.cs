using System;

namespace L13_C06_interface.Interfaces
{
	public interface IMusicRecorder
	{
		string RecordingDestination { get; set; }

		void RecordMusic(TimeSpan duration);
	}
}
