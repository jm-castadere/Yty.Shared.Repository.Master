using System.Collections.Generic;

namespace Yty.Shared.Repository.Master.Domain.Entities
{
    public class Wookie
    {
        public int Id { get; set; }

        public string Surname { get; set; }

        public List<Selfie> Selfies { get; set; }
    }
}
