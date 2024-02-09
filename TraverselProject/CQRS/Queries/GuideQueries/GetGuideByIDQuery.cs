using MediatR;
using System.Collections.Generic;
using TraverselProject.CQRS.Results.GuideResults;

namespace TraverselProject.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery : IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int iD)
        {
            ID = iD;
        }

        public int ID { get; set; }
    }
}
