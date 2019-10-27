namespace L12_C04_virtual_override_SW
{
	public class Passport : BaseDocument
	{
		public string Country { get; set; }

		public string PersonName { get; set; }

		public override string Description =>
			$"{Title} #{Number} issued "
			+ $"{IssueDate:dd-MM-yy} in "
			+ $"{Country} for {PersonName}";
	}
}
