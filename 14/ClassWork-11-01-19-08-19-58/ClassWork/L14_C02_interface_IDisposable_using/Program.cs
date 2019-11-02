namespace L14_C02_interface_IDisposable_using
{
	class Program
	{
		private static void Main()
		{
			using (var logger = new LogFileWriter("file.log"))
			{
				logger.WriteToLog("Program has stated.");
				logger.WriteToLog("Somewhere in the middle.");
				logger.WriteToLog("Finish");

				//throw new Exception();
			}
		}
	}
}
