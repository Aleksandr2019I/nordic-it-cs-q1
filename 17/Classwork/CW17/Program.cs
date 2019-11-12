using System;

namespace CW17
{
	public class RandomDataGenerator
	{
		public byte[] GetRandomData(int dataSize, int bytesDoneToRaiseEvent)
		{
			if (dataSize <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(dataSize));
			}
			if (bytesDoneToRaiseEvent <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(bytesDoneToRaiseEvent));
			}
			var bytes = new byte[dataSize];
			var random = new Random();
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] = (byte)random.Next();
				if (i % bytesDoneToRaiseEvent == 0)
				{
					RandomDataGenerating?.Invoke(this, new RandomDatageneraorEventArgs(i,dataSize));
				}
			}		
			RandomDataGenerated?.Invoke(this, null);
			return bytes;
		}

		public event EventHandler<RandomDatageneraorEventArgs> RandomDataGenerating;

		public class RandomDatageneraorEventArgs : EventArgs
		{
			public RandomDatageneraorEventArgs(int dataSize, int bytesDoneToRaiseEvent)
			{
				this.BataSize = dataSize;
				this.BytesDoneToRaiseEvent = bytesDoneToRaiseEvent;
			}

			public int BataSize { get; set; }
			public int BytesDoneToRaiseEvent { get; set; }


		}
		public event EventHandler RandomDataGenerated;
	}

	public delegate void RandomDataGeneratorHandler(int dataSize, int bytesDoneToRaiseEvent);

	internal class Program
	{
		static void Main(string[] args)
		{
			var generaot = new RandomDataGenerator();
			generaot.RandomDataGenerating += OneRandomDatagenereting;
			generaot.RandomDataGenerated += OneRandomgenereted;
			var data = generaot.GetRandomData(dataSize: 8, bytesDoneToRaiseEvent: 3);
			Console.ReadKey();
		}

			private static void OneRandomgenereted(object sender, EventArgs e)
			{
				Console.WriteLine($"data genereted");
			}

			private static void OneRandomDatagenereting(object sender, RandomDatageneraorEventArgs e)
			{
				Console.WriteLine($"Generate {bytesdone} data of {}");
			}

		
	}
	
}

