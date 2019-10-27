using System;

namespace L12_C01_hiding_members
{
	public class Employee : Person
	{
		public string EmployeeCode { get; set; }

		public DateTimeOffset HireDate { get; set; }

		public new string ShortDescription =>
			$"{GetType().Name} " +
			$"code: {EmployeeCode}, " +
			$"name: {Name}, " +
			$"date of birth: {DateOfBirth:dd-MM-yy}," +
			$"hire date: {HireDate:dd-MM-yy},";

		public new void WriteShortDescription()
		{
			Console.WriteLine(ShortDescription);
		}
	}
}
