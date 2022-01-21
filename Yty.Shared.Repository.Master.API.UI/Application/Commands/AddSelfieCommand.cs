using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yty.Shared.Repository.Master.API.Application.DTOs;

namespace Yty.Shared.Repository.Master.API.Application.Commands
{
    /// <summary>
    /// Command to add one selfie on database
    /// </summary>
    public class AddSelfieCommand : IRequest<SelfieDto>
    {
        #region Properties
        public SelfieDto Item { get; set; }
        #endregion
    }
}
