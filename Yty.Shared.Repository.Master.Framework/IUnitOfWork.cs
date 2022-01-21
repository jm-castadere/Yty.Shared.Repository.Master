using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yty.Shared.Repository.Master.Framework
{
    public interface IUnitOfWork
    {
        int SaveChanges();
    }
}
