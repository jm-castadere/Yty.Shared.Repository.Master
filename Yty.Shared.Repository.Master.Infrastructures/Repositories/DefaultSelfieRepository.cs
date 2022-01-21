using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Yty.Shared.Repository.Master.Domain.Entities;
using Yty.Shared.Repository.Master.Domain.Interfaces;
using Yty.Shared.Repository.Master.Framework;
using Yty.Shared.Repository.Master.Infrastructures.Data;

namespace Yty.Shared.Repository.Master.Infrastructures.Repositories
{
    public class DefaultSelfieRepository : ISelfieRepository
    {

        public IUnitOfWork UnitOfWork => _context;

        private readonly RepositoryMasterContext _context = null;

        public DefaultSelfieRepository(RepositoryMasterContext context)
        {
            this._context = context;
        }

        public ICollection<Selfie> GetAll(int wookieId)
        {
            var query = _context.Selfies.Include(item => item.Wookie).AsQueryable();

            if(wookieId > 0)
            {
                query = query.Where(item => item.WookieId == wookieId);
            }

            return query.ToList();
        }

        public Selfie AddOne(Selfie item)
        {
            return _context.Selfies.Add(item).Entity;
        }

        public Picture AddOnePicture(string url)
        {
            return _context.Pictures.Add(new Picture()
            {
                Url = url
            }).Entity;
        }
    }
}
