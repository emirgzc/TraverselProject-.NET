﻿using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TraverselProject.CQRS.Queries.GuideQueries;
using TraverselProject.CQRS.Results.DestinationResults;
using TraverselProject.CQRS.Results.GuideResults;

namespace TraverselProject.CQRS.Handlers.GuideQueries
{
	public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
	{
		private readonly Context _context;

		public GetAllGuideQueryHandler(Context context)
		{
			_context = context;
		}

		public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
		{
			return await _context.Guides.Select(x => new GetAllGuideQueryResult
			{
				GuideID = x.GuideID,
				Job = x.Job,
				Image = x.Image,
				Name = x.Name
			}).AsNoTracking().ToListAsync();
		}
	}
}
