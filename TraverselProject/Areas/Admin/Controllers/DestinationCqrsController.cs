using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using TraverselProject.CQRS.Commands.DestinationCommands;
using TraverselProject.CQRS.Handlers.DestinationHandlers;
using TraverselProject.CQRS.Queries.DestinationQueries;

namespace TraverselProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DestinationCqrsController : Controller
	{
		private readonly GetAllDestinationQueryHandler _queryHandler;
		private readonly GetDestinationByIDQueryHandler _queryIDHandler;
		private readonly CreateDestinationCommandHandler _commandCreateHandler;
		private readonly RemoveDestinationCommandHandler _commandRemoveHandler;
		private readonly UpdateDestinationCommandHandler _commandUpdateHandler;

		public DestinationCqrsController(GetAllDestinationQueryHandler queryHandler, GetDestinationByIDQueryHandler queryIDHandler, CreateDestinationCommandHandler commandCreateHandler, RemoveDestinationCommandHandler commandRemoveHandler, UpdateDestinationCommandHandler commandUpdateHandler)
		{
			_queryHandler = queryHandler;
			_queryIDHandler = queryIDHandler;
			_commandCreateHandler = commandCreateHandler;
			_commandRemoveHandler = commandRemoveHandler;
			_commandUpdateHandler = commandUpdateHandler;
		}

		public IActionResult Index()
		{
			var values = _queryHandler.Handle();
			return View(values);
		}
		[HttpGet]
		public IActionResult GetDestination(int id)
		{
			var values = _queryIDHandler.Handle(new GetDestinationByIDQuery(id));
			return View(values);
		}
		[HttpPost]
		public IActionResult GetDestination(UpdateDestinationCommand command)
		{
			_commandUpdateHandler.Handle(command);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult AddDestination()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddDestination(CreateDestinationCommand command)
		{
			_commandCreateHandler.Handle(command);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteDestination(int id)
		{
			_commandRemoveHandler.Handle(new RemoveDestinationCommand(id));
			return RedirectToAction("Index");
		}
	}
}
