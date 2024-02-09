namespace TraverselProject.CQRS.Commands.DestinationCommands
{
	public class UpdateDestinationCommand
	{
		public int desid { get; set; }
		public string city { get; set; }
		public string daynight { get; set; }
		public double price { get; set; }
	}
}
