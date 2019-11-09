using System;
using System.IO;

namespace HW13._1abstract
{
    class FileLogWriter : LogWriter
    {
        private readonly string _filename;

        public FileLogWriter(string filename)
        {
            _filename = filename;
        }

        protected override void WriteLine(string line)
        {
            File.AppendAllText(_filename, line);
        }
    }

}
