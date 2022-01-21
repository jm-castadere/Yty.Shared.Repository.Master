using System;
using System.Collections.Generic;
using Yty.Shared.Kernel.Enum;
using Yty.Shared.Kernel.Interfaces;

namespace Yty.Shared.Repository.Master.Domain.Entities
{

    /// <summary>
    /// The Abstract entity base. move to kernel or??
    /// </summary>
    public abstract class EntityBase<TId> : IEntity<TId>, IEntityWithIdentifier<TId>, IEntityWithPolicy<TId>, IEntityWithName, IEntityWithVersion<TId>, IEventSourcing
    {
       
        public DateTime? CreateDate { get; set; }
        public EntityStatus EntityStatus { get; set; }
        public long? VersionMasterMaxVersion { get; set; }
        public bool? VersonMasterIsCheckedOut { get; set; }
        public TId? VersonMasterId { get; set; }
        public long? Version { get; set; }
        public string? Name { get; set; }
        public string? SystemName { get; set; }
        public string? Namespace { get; set; }
        public TId PolicyId { get; set; }
        public string? ForeignId { get; set; }
        public TId Id { get; set; }
        //public VersionMaster<TId>? VersionMaster { get; set; }
        public string? Repository { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? Description { get; set; }
        EntityStatus IEntityWithStatus.EntityStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ClearUncommittedEvents()
        {
            throw new NotImplementedException();
        }

        public bool Equals(IEntity<TId> other)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDomainEvent> GetUncommittedEvents()
        {
            throw new NotImplementedException();
        }

        public void SetStatus(EntityStatus status)
        {
            throw new NotImplementedException();
        }

        //public void ApplyEvent(IDomainEvent @event);
        //public void ClearUncommittedEvents();
        //public bool Equals(IEntity<TId>? other);
        //public override bool Equals(object obj);
        //public override int GetHashCode();
        //public virtual EntityStatus GetStatus();
        //public IEnumerable<IDomainEvent> GetUncommittedEvents();
        //public void LoadFromHistory(IEnumerable<IDomainEvent> events);
        //public virtual void SetStatus(EntityStatus status);

        //public void SetStatus(EntityStatus status)
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual EntityStatus VerifyStatus();
        //protected void AddDomainEvent(IDomainEvent @event);

        EntityStatus IEntityWithStatus.GetStatus()
        {
            throw new NotImplementedException();
        }

        EntityStatus IEntityWithStatus.VerifyStatus()
        {
            throw new NotImplementedException();
        }
    }
}

