using System;
namespace CW10
{
	class Pet
	{
		// У публичных полей название с БОЛЬШОЙ буквы.
		// 
		public string Kind;

		public string Name;

		public char Sex;

		public int Age;

		public Pet()
		{
		}
		//public string Description
		//{
		//	get
		//	{
		//		return $"The lalal {Name},{Kind},{Sex},{Age}";
		//	}
		//}

		public string Description =>
			$"The lalal {Name},{Kind},{Sex},{Age}";

	}
}
