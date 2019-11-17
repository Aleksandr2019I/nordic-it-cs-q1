using System;
using System.Collections.Generic;
using System.Text;

namespace L17_C06_events_eventargs_SW
{
	public class RandomDataGeneratedEventArgs: EventArgs
	{
		public byte[] RandomData { get; set; }
	}
}
