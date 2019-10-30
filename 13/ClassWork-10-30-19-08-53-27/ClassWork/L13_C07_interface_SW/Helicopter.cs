using System;
using L13_C07_interface_SW.Interfaces;

namespace L13_C07_interface_SW
{
	class Helicopter : FlyingObject, IHelicopter
	{
		public byte BladesCount { get; private set; }

		public Helicopter(int maxHeight, byte bladesCount) : base(maxHeight)
		{
			BladesCount = bladesCount;
			Console.WriteLine("It’s a helicopter, welcome aboard!");
		}

		public override void WriteAllProperties()
		{
			Console.WriteLine(
				$"Properties of {GetType().Name}:" +
				$"\n\t{nameof(BladesCount)}:\t{BladesCount}" +
				$"\n\t{nameof(MaxHeight)}:\t{MaxHeight}" +
				$"\n\t{nameof(CurrentHeight)}:\t{CurrentHeight}\n");
		}
	}
}
