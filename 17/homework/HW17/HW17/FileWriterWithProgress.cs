using System;
using System.IO;

namespace HW17
{
	internal partial class Program
	{
		public class FileWriterWithProgress
		{
			public event EventHandler<WritingPerformedEventArgs> WritingPerformed;
			public event EventHandler<WritingCompletedEventArgs> WritingCompleted;

			public string FileName { get; set; }

			public FileWriterWithProgress(string fileName)
			{
				FileName = fileName;
			}

			public void WriteBytes(string fileName, byte[] data, float percentageToFileEvent)
			{
				if (string.IsNullOrWhiteSpace(fileName))
				{
					throw new ArgumentException(nameof(fileName));
				}
				if (data == null)
				{
					throw new ArgumentException(nameof(data));
				}
				if (percentageToFileEvent <= 0)
				{
					throw new ArgumentException(nameof(percentageToFileEvent));
				}

				using (FileStream fs = File.OpenWrite(fileName))
				{
					for (int i = 0; i < data.Length; i++)
					{
						fs.WriteByte(data[i]);
						if ((data[i] / 100.0 % percentageToFileEvent)   == 10) //?? muthdimreminder
						{
							WritingPerformed?.Invoke(this, new WritingPerformedEventArgs(percentageToFileEvent));
						}
					}
					WritingCompleted?.Invoke(this, data);
				}
			}
		}
	}
}