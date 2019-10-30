namespace L13_C06_interface.Interfaces
{
	public interface IVideoPlayer
	{
		string VideoSource { get; set; }

		void PlayVideo();
	}
}
