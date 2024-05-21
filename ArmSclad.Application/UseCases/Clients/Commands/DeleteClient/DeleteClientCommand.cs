using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Clients.Commands.DeleteClient
{
    internal class DeleteClientCommand : IRequest
    {
        public ClientEntity ClientEntity { get; set; }
    }
}
