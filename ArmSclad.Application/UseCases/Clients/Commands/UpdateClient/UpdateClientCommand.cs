using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Clients.Commands.UpdateClient
{
    public class UpdateClientCommand : IRequest
    {
        public ClientEntity ClientEntity { get; set; }
    }
}
