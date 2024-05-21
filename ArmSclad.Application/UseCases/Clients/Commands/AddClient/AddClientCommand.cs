using ArmSclad.Core.Entities;
using MediatR;

namespace ArmSclad.Domain.UseCases.Clients.Commands.AddClient
{
    public class AddClientCommand : IRequest<int>
    {
        public ClientEntity ClientEntity { get; set; }
    }
}
