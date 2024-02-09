using DataAccessLayer.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TraverselProject.CQRS.Queries.GuideQueries;
using TraverselProject.CQRS.Results.DestinationResults;
using TraverselProject.CQRS.Results.GuideResults;

namespace TraverselProject.CQRS.Handlers.GuideQueries
{
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.ID);
            return new GetGuideByIDQueryResult
            {
                GuideID = values.GuideID,
                Job = values.Job,
                Name = values.Name
            };
        }
    }
}
