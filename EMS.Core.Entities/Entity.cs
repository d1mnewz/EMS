using System;

namespace EMS.Core.Entities
{
    public abstract class Entity : Entity<Guid>
    {

    }
    public abstract class Entity<T>
    {
        public T Id { get; set; }
        public bool IsDeleted { get; set; }
        //private Metadata Metadata { get; set; } // Metadata isn't displayed in DB and isn't recorded

    }
}