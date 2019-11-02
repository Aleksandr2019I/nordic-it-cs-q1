using System;
using System.Collections;
using System.Collections.Generic;

namespace L14_C04_interface_IEnumerable
{
	class Program
	{
		private static void Main()
		{
			var list = new List<string>
			{
				"One",
				"Two",
			};

			foreach (var item in list)
			{
				Console.WriteLine(item);
			}

			var historyList = new HistoryList()
			{
				"One",
				"Two"
			};

			foreach (var item in historyList)
			{
				Console.WriteLine(item);
			}


			foreach (var number in new RandomGenerator(count: 5))
			{
				Console.WriteLine(number);
			}


			IEnumerator<string> enumerator = default;

			//    1, 2, 3, 4
			//
			//  ^
			//  |
			// MoveNext()
			//    ^
			//    |
			//  MoveNext()
			//       ^
			//       |
			//   MoveNext()
			//          ^
			//          |
			//    MoveNext()
			//             ^
			//             |

			try
			{
				// GetEnumerator() from IEnumerable<string>
				enumerator = list.GetEnumerator();

				// MoveNext() from IEnumerator<string>
				while (enumerator.MoveNext())
				{
					// Current from IEnumerator<string>
					Console.WriteLine(enumerator.Current);
				}
			}
			finally
			{
				if (enumerator != null)
				{
					// Dispable from IEnumerator<string>
					enumerator.Dispose();
				}
			}
		}
	}
}
