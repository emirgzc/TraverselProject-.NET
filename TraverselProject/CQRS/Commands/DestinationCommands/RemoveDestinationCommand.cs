namespace TraverselProject.CQRS.Commands.DestinationCommands
{
	public class RemoveDestinationCommand
	{
		public RemoveDestinationCommand(int destid)
		{
			this.destid = destid;
		}

		public int destid { get; set; }
    }
}
