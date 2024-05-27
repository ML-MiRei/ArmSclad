using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Clients.Commands.DeleteClient
{
    public class DeleteClientCommand : IRequest
    {
        public int ClientId { get; set; }
    }
}
