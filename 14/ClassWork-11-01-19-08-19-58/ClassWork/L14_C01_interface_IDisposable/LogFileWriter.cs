using System;
using System.IO;

namespace L14_C01_interface_IDisposable
{
	class LogFileWriter : IDisposable
	{
		private readonly StreamWriter _writer;

		public string LogFileName { get; }

		public LogFileWriter(string fileName)
		{
			LogFileName = fileName;
			_writer = File.AppendText(fileName);
		}

		public void WriteToLog(string message)
		{
			_writer.WriteLine($"{DateTime.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\t{message}");
			_writer.Flush();
		}

		public void Dispose()
		{
			_writer.Dispose();
		}
	}
}
