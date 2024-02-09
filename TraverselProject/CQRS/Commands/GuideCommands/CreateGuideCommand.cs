using MediatR;

namespace TraverselProject.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommand : IRequest
    {
        public string Name { get; set; }
        public string Job { get; set; }
    }
}
