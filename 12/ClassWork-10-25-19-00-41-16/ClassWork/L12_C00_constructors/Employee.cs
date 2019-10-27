namespace L12_C00_constructors
{
	public class Employee : Person
	{
		public string Organization { get; set; }
		// System.String-Employee:Organization
		// System.String Person:Type
		// System.String Employee:Type

		public new string Type => "Worker";
	}
}
