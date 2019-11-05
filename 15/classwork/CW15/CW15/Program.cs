using System;


namespace CW15
{
	class Program
	{
		static void Main(string[] args)
		{
			var first = new Account<int>(12,"po");
			var second = new Account<string>("text","text2");
			var guides = new Account<Guid>(Guid.NewGuid(), "pff");
			first.WriteProperties();
			second.WriteProperties();
			guides.WriteProperties();
			Console.ReadKey();
		}
	}

	class Account<T>
	{
		public  T Id { get; private set; }
		public string Name { get; private set; }

		public Account( T id, string name)
		{
			Id = id;
			Name = name;
		}
		public void WriteProperties()
		{
			Console.WriteLine($"id - {Id},name - {Name}");

		}


	
	}
	
}
