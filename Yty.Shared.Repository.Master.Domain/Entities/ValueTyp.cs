using System.Collections.Generic;

namespace Yty.Shared.Repository.Master.Domain.Entities
{
    public class ValueTyp
    {
        public int Id { get; set; }

        //Value typ (Int, string..)
        public string TypName { get; set; }

        //can be null
        public bool CanBeNull { get; set; }
    }
}
