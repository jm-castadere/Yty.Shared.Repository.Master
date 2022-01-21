using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yty.Shared.Repository.Master.Domain;

namespace Yty.Shared.Repository.Master.Domain.Entities
{
    public class Picture
    {
        public Picture(){}

        public int Id { get; set; }

        public string Url { get; set; }

        public List<Selfie> Selfies { get; set; }
    }
}
