using System;
using L13_C06_interface.Interfaces;

namespace L13_C06_interface.Device
{
	class MobilePhone: MusicPlayer, ICaller, IMusicPlayer, IRestartable
	{
		public MobilePhone(ConsoleWriter writer): base(writer)
		{
			_writer.WriteLine("Starting work with Mobile Phone", ConsoleColor.Cyan);
		}

		public void Call(string phoneNumber)
		{
			_writer.WriteLine($"Calling {phoneNumber}...");
		}

		public override void Restart()
		{
			_writer.WriteLine("Restarting Mobile Phone... Displaying splash screen while loading.", ConsoleColor.Cyan);
		}
	}
}
