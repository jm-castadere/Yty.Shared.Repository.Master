using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Yty.Shared.Repository.Master.Domain;
using Yty.Shared.Repository.Master.API.Application.DTOs;
using Yty.Shared.Repository.Master.API.Application.Queries;
using Yty.Shared.Repository.Master.Domain.Interfaces;

namespace Yty.Shared.Repository.Master.API.Application.Queries
{

    public class SelectAllSelfiesHandler : IRequestHandler<SelectAllSelfiesQuery, List<Yty.Shared.Repository.Master.API.Application.DTOs.SelfieResumeDto>>
    {
        #region Fields
        private readonly ISelfieRepository _repository = null;
        #endregion

        #region Constructors
        public SelectAllSelfiesHandler(ISelfieRepository repository)
        {
            this._repository = repository;
        }
        #endregion

        #region Public methods
        public Task<List<SelfieResumeDto>> Handle(SelectAllSelfiesQuery request, CancellationToken cancellationToken)
        {
            var selfiesList = this._repository.GetAll(request.WookieId);
            var result = selfiesList.Select(item => new SelfieResumeDto() { Title = item.Title, WookieId = item.Wookie.Id, NbSelfiesFromWookie = (item.Wookie?.Selfies?.Count).GetValueOrDefault(0) }).ToList();

            return Task.FromResult(result);
        }
        #endregion
    }
}
