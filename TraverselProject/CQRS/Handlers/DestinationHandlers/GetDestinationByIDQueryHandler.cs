using DataAccessLayer.Concrete;
using TraverselProject.CQRS.Queries.DestinationQueries;
using TraverselProject.CQRS.Results.DestinationResults;

namespace TraverselProject.CQRS.Handlers.DestinationHandlers
{
	public class GetDestinationByIDQueryHandler
	{
		private readonly Context _context;

		public GetDestinationByIDQueryHandler(Context context)
		{
			_context = context;
		}
		public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
		{
			var values = _context.Destinations.Find(query.id);
			return new GetDestinationByIDQueryResult
			{
				desid = values.DestinationID,
				city = values.City,
				daynight = values.DayNight,
				price = values.Price
			};
		}
	}
}
