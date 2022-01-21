using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yty.Shared.Repository.Master.API.Application.DTOs
{
    public class AuthenticateUserDto
    {
        #region Properties
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        #endregion
    }
}
