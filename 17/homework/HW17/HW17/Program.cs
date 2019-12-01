using System;
namespace HW17
{
    internal partial class Program
    {
        static void Main()
        {
            Console.WriteLine("путь");
            var filename = @"f:\c#\log.log";

            var writer = new FileWriterWithProgress(filename);

            writer.WritingPerformed += Writer_WritingPerformed;
            writer.WritingCompleted += Writer_WritingCompleted;
            writer.WriteBytes(filename, new byte[10], 0.2f);
            Console.ReadKey();
        }
        private static void Writer_WritingPerformed(object sender, WritingPerformedEventArgs e)
        {
            Console.WriteLine($"//будет {e.Data} - событий WritingPerformed при достижении  записи ");
        }
        private static void Writer_WritingCompleted(object sender, WritingCompletedEventArgs e)
        {
            Console.WriteLine($"//+ {e} событие WritingCompleted при завершении.");
        }
    }
}