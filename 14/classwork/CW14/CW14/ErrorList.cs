using System;
using System.Collections;
using System.Collections.Generic;
namespace CW14
{
	public class ErrorList : IDisposable,IEnumerable<string>
	{
		public string Category
		{
			get;
		}
		private List<string> _errors;
		public ErrorList(string category, List<string> errors)
		{
			Category = category;
			_errors = errors;
		}
		public void Dispose()
		{
			_errors.Clear();
			_errors = null;
		}
		public void Add(string errorMessage)
		{
			_errors.Add(errorMessage);

		}
		public IEnumerator<string> GetEnumerator()
		{
			return _errors.GetEnumerator();
		}
	    IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}