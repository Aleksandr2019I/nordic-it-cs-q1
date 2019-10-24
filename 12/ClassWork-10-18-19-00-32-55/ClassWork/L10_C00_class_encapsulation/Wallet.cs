using System;

namespace L10_C00_class_encapsulation
{
	class Wallet
	{
		// anternative naming
		// private string m_material;
		private string _material;
		public string Material
		{
			get
			{
				return _material;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Value must be not empty");
				}
				_material = value;
			}
		}

		//private string owner;
		//public string Owner
		//{
		//	get { return owner; }
		//	set { owner = value; }
		//}
		public string Owner { get; set; }

		private decimal _money;
		public decimal Money
		{
			get
			{
				return _money;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Value must be positive");
				}
				_money = value;
			}
		}

		public Wallet()
		{
		}

		public Wallet(decimal money)
		{
			Money = money;
		}

		public Wallet(decimal money, string material, string owner)
		{
			Money = money;
			Material = material;
			Owner = owner;
		}
	}
}

