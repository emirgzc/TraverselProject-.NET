using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using TraverselProject.CQRS.Commands.DestinationCommands;

namespace TraverselProject.CQRS.Handlers.DestinationHandlers
{
	public class CreateDestinationCommandHandler
	{
		private readonly Context _context;

		public CreateDestinationCommandHandler(Context context)
		{
			_context = context;
		}
		public void Handle(CreateDestinationCommand command)
		{
			_context.Destinations.Add(new Destination
			{
				City = command.City,
				DayNight = command.DayNight,
				Price = command.Price,
				Capacity = command.Capacity,
				Status = true
			});
			_context.SaveChanges();
		}
	}
}
