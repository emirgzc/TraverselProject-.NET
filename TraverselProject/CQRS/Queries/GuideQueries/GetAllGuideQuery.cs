
using MediatR;
using System.Collections.Generic;
using TraverselProject.CQRS.Results.GuideResults;

namespace TraverselProject.CQRS.Queries.GuideQueries
{
	public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
	{
	}
}
