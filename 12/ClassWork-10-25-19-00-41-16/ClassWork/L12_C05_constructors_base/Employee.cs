using System;
using System.Diagnostics;

namespace L12_C05_constructors_base
{
	public class Employee : Person
	{
		public string EmployeeCode { get; set; }

		public DateTimeOffset HireDate { get; set; }

		public Employee(
			string code,
			DateTimeOffset hireDate,
			string name, 
			DateTimeOffset dateOfBirth) : base(name, dateOfBirth)
		{
			EmployeeCode = code;
			HireDate = hireDate;
			Console.WriteLine("Constructor Employee(code, hireDate, name, dateOfBirth) called");
		}

		public override string ShortDescription =>
			$"{GetType().Name} " +
			$"code: {EmployeeCode}, " +
			$"name: {Name}, " +
			$"date of birth: {DateOfBirth:dd-MM-yy}, " +
			$"hire date: {HireDate:dd-MM-yy}";
	}
}
