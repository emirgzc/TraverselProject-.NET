using DataAccessLayer.Concrete;
using TraverselProject.CQRS.Commands.DestinationCommands;

namespace TraverselProject.CQRS.Handlers.DestinationHandlers
{
	public class UpdateDestinationCommandHandler
	{
		private readonly Context _context;

		public UpdateDestinationCommandHandler(Context context)
		{
			_context = context;
		}
		public void Handle(UpdateDestinationCommand command)
		{
			var values = _context.Destinations.Find(command.desid);
			values.City = command.city;
			values.DayNight = command.daynight;
			values.Price = command.price;
			_context.SaveChanges();
		}
	}
}
