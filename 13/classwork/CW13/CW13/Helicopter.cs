// abstract readonly protected
using System;
namespace CW13
{
	class Helicopter : PlaneHeli, IBladesCount, ITake
	{
		public byte BladesCount { get; set; }
		public Helicopter(int maxHeight,byte bladesCount)
			: base (maxHeight,0)
		{
			BladesCount = bladesCount;
			Console.WriteLine("It's a Helicopter, welcome aboard!");			
		}

		public void WriteAllProperties()
		{
			Console.WriteLine("Properties of helicopter:");
			Console.WriteLine($"BladesCount  = {BladesCount} ");
			Console.WriteLine($"CurrentHeight = {CurrentHeight} ");
			Console.WriteLine($"MaxHeight = {MaxHeight} ");
			Console.WriteLine();

		}


		
		


	}
}
