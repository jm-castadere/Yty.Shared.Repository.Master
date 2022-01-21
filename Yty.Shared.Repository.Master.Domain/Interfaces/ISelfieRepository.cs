using System.Collections.Generic;
using Yty.Shared.Repository.Master.Domain.Entities;
using Yty.Shared.Repository.Master.Framework;

namespace Yty.Shared.Repository.Master.Domain.Interfaces
{
    /// <summary>
    /// Repository to manage selfies
    /// </summary>
    public interface ISelfieRepository : IRepository
    {
        /// <summary>
        /// Gets all selfies
        /// </summary>
        /// <returns></returns>
        ICollection<Selfie> GetAll(int wookieId);

        /// <summary>
        /// Adds one slefie in database 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Selfie AddOne(Selfie item);



        //Picture AddOnePicture(string url);

    }
}
