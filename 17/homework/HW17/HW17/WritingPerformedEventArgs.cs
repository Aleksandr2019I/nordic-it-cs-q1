using System;

namespace HW17
{
    public class WritingPerformedEventArgs : EventArgs
    {
        public float PercentageToFileEvent { get; set; }
        public byte[] Data { get; set; }
    }
}