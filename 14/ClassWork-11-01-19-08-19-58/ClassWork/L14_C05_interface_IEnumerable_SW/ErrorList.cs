using System;
using System.Collections;
using System.Collections.Generic;

namespace L14_C05_interface_IEnumerable_SW
{
	class ErrorList : IDisposable, IEnumerable<string>
	{
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
