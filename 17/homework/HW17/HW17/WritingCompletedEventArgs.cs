using System;

namespace HW17
{
	public class WritingCompletedEventArgs : EventArgs
	{ 
        public byte[] Data { get; set; }
    }
}