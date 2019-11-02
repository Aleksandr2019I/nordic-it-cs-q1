using System;
using System.Collections;
using System.Collections.Generic;

namespace L14_C04_interface_IEnumerable
{
	class RandomGenerator : IEnumerable<int>
	{
		class RandomGeneratorEnumerator : IEnumerator<int>
		{
			private readonly Random _random;
			private readonly int _count;
			private int _current;

			public RandomGeneratorEnumerator(Random random, int count)
			{
				_random = random;
				_count = count;
				_current = -1;
			}

			public int Current =>
				_random.Next();

			object IEnumerator.Current =>
				this.Current;

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return ++_current < _count;
			}

			public void Reset()
			{
			}
		}

		private int _count;

		public RandomGenerator(int count)
		{
			_count = count;
		}

		public IEnumerator<int> GetEnumerator()
		{
			var random = new Random();
			return new RandomGeneratorEnumerator(random, _count);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
