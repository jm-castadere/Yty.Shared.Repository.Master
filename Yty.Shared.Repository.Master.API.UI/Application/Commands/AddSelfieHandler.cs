using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Yty.Shared.Repository.Master.API.Application.DTOs;
using Yty.Shared.Repository.Master.Domain.Entities;
using Yty.Shared.Repository.Master.Domain.Interfaces;

namespace Yty.Shared.Repository.Master.API.Application.Commands
{
    public class AddSelfieHandler : IRequestHandler<AddSelfieCommand, SelfieDto>
    {
        private readonly ISelfieRepository _repository = null;

        public AddSelfieHandler(ISelfieRepository repository)
        {
            this._repository = repository;
        }

        public Task<SelfieDto> Handle(AddSelfieCommand request, CancellationToken cancellationToken)
        {
            SelfieDto result = null;

            Selfie addSelfie = this._repository.AddOne(new Selfie()
            {
                ImagePath = request.Item.ImagePath,
                Title = request.Item.Title
            });

            this._repository.UnitOfWork.SaveChanges();

            if (addSelfie != null)
            {
                request.Item.Id = addSelfie.Id;
                result = request.Item;
            }

            return Task.FromResult(result);
        }
    }
}
