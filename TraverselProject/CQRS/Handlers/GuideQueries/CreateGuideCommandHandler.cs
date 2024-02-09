using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TraverselProject.CQRS.Commands.GuideCommands;

namespace TraverselProject.CQRS.Handlers.GuideQueries
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Name = request.Name,
                Job = request.Job,
                Status = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
