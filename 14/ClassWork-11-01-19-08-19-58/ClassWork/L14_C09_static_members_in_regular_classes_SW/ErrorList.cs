using System;
using System.Collections;
using System.Collections.Generic;

namespace L14_C09_static_members_in_regular_classes_SW
{
	class ErrorList : IDisposable, IEnumerable<string>
	{
		public static string OutputPrefixFormat { get; set; }

		private static string OutputPrefix => DateTime.Now.ToString(OutputPrefixFormat);

		static ErrorList()
		{
			OutputPrefixFormat = "MMMM d, yyyy (hh:mm tt)";
		}

		private List<string> _errors;

		public string Category { get; }

		public void Add(string errorMessage)
		{
			_errors.Add(errorMessage);
		}

		public ErrorList(string category)
		{
			_errors = new List<string>();
			Category = category;
		}

		public void WriteToConsole()
		{
			foreach (var error in _errors)
			{
				Console.WriteLine($"{OutputPrefix}{Category} {error}");
			}
		}

		public void Dispose()
		{
			if (_errors != null)
			{
				_errors.Clear();
				_errors = null;
			}
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _errors.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _errors.GetEnumerator();
		}
	}
}
