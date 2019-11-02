namespace L14_C01_interface_IDisposable
{
	class Program
	{
		private static void Main()
		{
			var logger = new LogFileWriter("file.log");

			logger.WriteToLog("Program has stated.");
			logger.WriteToLog("Somewhere in the middle.");
			logger.WriteToLog("Finish");

			//throw new Exception();

			logger.Dispose();
		}
	}
}
