// abstract readonly protected
using System;
namespace CW13
{
	class Plane : PlaneHeli ,IEnginesCount, ITake
	{
		public byte EnginesCount { get; set; }
		public Plane(int maxHeight, byte enginesCount)
			: base(maxHeight, 0)
		{
			EnginesCount = enginesCount;
			Console.WriteLine("it's a plane, welcome aboard!");
		}
		public void WriteAllProperties()
		{
			Console.WriteLine("Properties of helicopter:");
			Console.WriteLine($"BladesCount  = {EnginesCount} ");
			Console.WriteLine($"CurrentHeight = {CurrentHeight} ");
			Console.WriteLine($"MaxHeight = {MaxHeight} ");
			Console.WriteLine();
		}


	}
}
