// abstract readonly protected
using System;
namespace CW13
{

	  class PlaneHeli : ITake
	{
		public PlaneHeli(int maxHeight, int currentHeight)
		{
			MaxHeight = maxHeight;
			CurrentHeight = currentHeight;
		}

		public int MaxHeight { get; set; }
		public int CurrentHeight { get; set; }
		
		public void TakeUpper(int delta)
		{
			if (delta <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(delta),"BLABLABLA");
			}
			if ((CurrentHeight + delta) > MaxHeight)
			{
				MaxHeight = MaxHeight;
			}
			else
			{
				MaxHeight = CurrentHeight + delta;
			}
		}
		public void TakeLower(int delta)
		{
			if (delta <= 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (CurrentHeight - delta > 0)
			{
				CurrentHeight = CurrentHeight - delta;
			}
			if (CurrentHeight - delta == 0)
			{
				CurrentHeight = 0;
			}
			if (CurrentHeight < 0)
			{
				throw new InvalidOperationException();
				
			}

		}
	}
}
