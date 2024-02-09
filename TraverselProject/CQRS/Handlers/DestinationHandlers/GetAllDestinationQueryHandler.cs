using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TraverselProject.CQRS.Queries.DestinationQueries;
using TraverselProject.CQRS.Results.DestinationResults;

namespace TraverselProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x=> new GetAllDestinationQueryResult
            {
                id = x.DestinationID,
                capacity = x.Capacity,
                city = x.City,
                dayNight = x.DayNight,
                price = x.Price
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
