using DataAccessLayer.Concrete;
using TraverselProject.CQRS.Commands.DestinationCommands;

namespace TraverselProject.CQRS.Handlers.DestinationHandlers
{
	public class RemoveDestinationCommandHandler
	{
		private readonly Context _context;

		public RemoveDestinationCommandHandler(Context context)
		{
			_context = context;
		}
		public void Handle(RemoveDestinationCommand command)
		{
			var values = _context.Destinations.Find(command.destid);
			_context.Destinations.Remove(values);
			_context.SaveChanges();
		}
	}
}
