using System;
// abstract readonly protected
namespace CW13
{
	public interface class ITake
	{
		void TakeUpper(int delta);
		void TakeLower(int delta);
	}

	public interface class IEnginesCount
	{
		void EnginesCount();
	}

	public interface class IBladesCount
	{
		void BladesCount();
	}
	class Program
	{
		static void Main(string[] args)
		{
			var plane = new Plane(200,254);
			var helicopter = new Helicopter(750,200);

			plane.TakeUpper(200);
			plane.TakeLower(150);
			plane.WriteAllProperties();
			helicopter.TakeUpper(350);
			helicopter.TakeLower(500);
			helicopter.WriteAllProperties();
			Console.ReadKey();
		}
		
	}

}
