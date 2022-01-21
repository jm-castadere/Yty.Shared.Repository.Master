using System;

namespace Yty.Shared.Repository.Master.Domain.Entities
{
    public class EntityDefinition : EntityBase<Guid>
    {

        public Guid Id { get; set; }

        public string Name { get; set; }



    }
}
