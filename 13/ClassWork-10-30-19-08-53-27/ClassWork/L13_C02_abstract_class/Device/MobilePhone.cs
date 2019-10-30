using System;

namespace L13_C02_abstract_class.Device
{
	class MobilePhone : MusicPlayer
	{
		public MobilePhone(ConsoleWriter writer): base(writer)
		{
			Writer.WriteLine("Starting work with Mobile Phone", ConsoleColor.Cyan);
		}

		public void Call(string phoneNumber)
		{
			Writer.WriteLine($"Calling {phoneNumber}...");
		}

		public void Restart()
		{
			Writer.WriteLine("Restarting Mobile Phone... Displaying splash screen while loading.", ConsoleColor.Cyan);
		}
	}
}
