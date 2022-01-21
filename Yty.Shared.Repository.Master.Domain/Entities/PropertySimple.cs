using System;

using Yty.Shared.Kernel.Entities;

namespace Yty.Shared.Repository.Master.Domain.Entities
{
    /// <summary>
    /// The simple entity property.
    /// </summary>
    /// <remarks>Implement abstract class Yty.Shared.Kernel.Entities.Entity </remarks>
    public class PropertySimple : Entity<Guid>
    {
         public string Name { get; set; }

        public ValueTyp Value { get; set; }


    }
}
