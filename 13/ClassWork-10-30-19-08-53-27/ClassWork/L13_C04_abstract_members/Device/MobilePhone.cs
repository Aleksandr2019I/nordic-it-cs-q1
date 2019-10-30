using System;

namespace L13_C04_abstract_members.Device
{
	class MobilePhone: MusicPlayer
	{
		public MobilePhone(ConsoleWriter writer): base(writer)
		{
			Writer.WriteLine("Starting work with Mobile Phone", ConsoleColor.Cyan);
		}

		public void Call(string phoneNumber)
		{
			Writer.WriteLine($"Calling {phoneNumber}...");
		}

		public override void Restart()
		{
			Writer.WriteLine("Restarting Mobile Phone... Displaying splash screen while loading.", ConsoleColor.Cyan);
		}
	}
}
