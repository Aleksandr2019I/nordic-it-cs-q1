using System;

namespace L17_C04_events_SW
{
	public delegate void RandomDataGeneratedHandler(int bytesDone, int totalBytes);

	public class RandomDataGenerator
	{
		public event RandomDataGeneratedHandler RandomDataGenerating;
		public event EventHandler RandomDataGenerated;

		public byte[] GetRandomData(int dataSize, int bytesDoneToRaiseEvent)
		{
			var result = new byte[dataSize];
			var rand = new Random();

			for(var i = 0; i < dataSize; i++)
			{
				result[i] = (byte)rand.Next(256);

				if ((i + 1) % bytesDoneToRaiseEvent == 0)
				{
					OnRandomDataGenerating(i + 1, dataSize);
				}
			}

			OnRandomDataGenerated(this, EventArgs.Empty);

			return result;
		}

		protected virtual void OnRandomDataGenerating(int bytesDone, int totalBytes)
		{
			if (RandomDataGenerating != null)
			{
				RandomDataGenerating(bytesDone, totalBytes);
			}
		}

		protected virtual void OnRandomDataGenerated(object sender, EventArgs e)
		{
			if (RandomDataGenerated != null)
			{
				RandomDataGenerated(sender, e);
			}
		}
	}
}
