using System;
using System.IO;
namespace HW17
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("путь");
            var filename = "log.log";
            var writer = new FileWriterWithProgress(filename);

            writer.WritingPerformed += Writer_WritingPerformed;
            writer.WritingCompleted += Writer_WritingCompleted;
            writer.WriteBytes(filename, new byte[10], 0.2f);
            Console.ReadKey();
        }
        private static void Writer_WritingCompleted(object sender, FileWriterWithProgress e)
        {
            Console.WriteLine($"конец процесса ");
        }
        private static void Writer_WritingPerformed(object sender, FileWriterWithProgress e)
        {
            Console.WriteLine($"//будет событий - событий WritingPerformed при достижении  записи ");
        }
        public class FileWriterWithProgress : EventArgs
        {
            public string FileName { get; }
            public FileWriterWithProgress(string fileName)
            {
                FileName = fileName;
            }
            public event EventHandler<FileWriterWithProgress> WritingPerformed;
            public event EventHandler<FileWriterWithProgress> WritingCompleted;       
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
                for (int i = 0; i < data.Length; i++)
                {
                    File.AppendAllText(fileName, $"{data[i]}");
                    if ((i/100.0) % percentageToFileEvent == 0)
                    {
                        WritingPerformed?.Invoke(this, new FileWriterWithProgress(FileName));
                    }
                   
                }
				WritingCompleted?.Invoke(this, null);
			}
            // алгоритм тотже только теперь байты  не записыватся в массив,а читаются из массива и пишутся в файл
        }
    }
}