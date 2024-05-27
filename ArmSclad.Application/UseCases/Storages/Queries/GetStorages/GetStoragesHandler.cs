using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Repository;
using MediatR;

namespace ArmSclad.Domain.UseCases.Storages.Queries.GetStorages
{
    internal class GetStoragesHandler(IStoragesRepository storagesRepository) : IRequestHandler<GetStoragesQuery, List<StorageEntity>>
    {
        public Task<List<StorageEntity>> Handle(GetStoragesQuery request, CancellationToken cancellationToken)
        {
            if (request.FilterStorages == null)
                return Task.Run(() => storagesRepository.Get(request.From, request.To));
            return Task.Run(() => storagesRepository.Get(request.FilterStorages, request.From, request.To));

        }
    }
}
