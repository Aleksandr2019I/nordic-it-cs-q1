using System.Collections;
using System.Collections.Generic;

namespace L14_C04_interface_IEnumerable
{
	class HistoryList : IEnumerable<string>
	{
		private readonly List<string> _list = new List<string>();

		public void Add(string item)
		{
			_list.Add(item);
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _list.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _list.GetEnumerator();
		}
	}
}
