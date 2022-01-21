using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yty.Shared.Repository.Master.API.Application.DTOs;

namespace Yty.Shared.Repository.Master.API.Application.Queries
{
    /// <summary>
    /// Query to select all selfies (with dto class)
    /// </summary>
    public class SelectAllSelfiesQuery : IRequest<List<SelfieResumeDto>>
    {
        #region Properties
        public int WookieId { get; set; }
        #endregion
    }
}
