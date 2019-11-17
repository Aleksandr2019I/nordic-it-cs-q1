using System;
namespace CW17
{
	public class RandomDataGenerator
	{
        public event EventHandler<RandomDatageneraorEventArgs> RandomDataGenerating;
        public event EventHandler RandomDataGenerated;
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
		public class RandomDatageneraorEventArgs : EventArgs
		{
			public RandomDatageneraorEventArgs(int dataSize, int bytesDoneToRaiseEvent)
			{
				DataSize = dataSize;
				BytesDoneToRaiseEvent = bytesDoneToRaiseEvent;
			}
			public int DataSize { get; set; }
			public int BytesDoneToRaiseEvent { get; set; }
		}		
	}
	//public delegate void RandomDataGeneratedHandler(int dataSize, int bytesDoneToRaiseEvent);
	internal class Program
	{
		static void Main(string[] args)
		{
			var generator = new RandomDataGenerator();
            generator.RandomDataGenerating += OneRandomDatagenereting;
			generator.RandomDataGenerated += OneRandomgenereted;
			var data = generator.GetRandomData(dataSize: 8, bytesDoneToRaiseEvent: 3);
			Console.ReadKey();
		}
        private static void OneRandomgenereted(object sender, EventArgs e)
			{
				Console.WriteLine($"data genereted");
			}
			private static void OneRandomDatagenereting(int bytesDone, int totalBytes)
			{
				Console.WriteLine($"Generate {bytesDone} data of {totalBytes}");
			}		
	}	
}

