using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace L13_C01_abstract_source
{
	class ConsoleWriter
	{
		public ConsoleWriter() :
			this(CultureInfo.InvariantCulture, Encoding.Unicode)
		{
		}

		public ConsoleWriter(CultureInfo cultureInfo, Encoding encoding)
		{
			Thread.CurrentThread.CurrentCulture = cultureInfo;
			Thread.CurrentThread.CurrentUICulture = cultureInfo;
			Console.InputEncoding = encoding;
			Console.OutputEncoding = encoding;
		}

		public void WriteLine(string text, ConsoleColor color = ConsoleColor.White)
		{
			var restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.WriteLine(text);
			Console.ForegroundColor = restoreColor;
		}

		public void ReadKey()
		{
			Console.ReadKey();
		}
	}
}
