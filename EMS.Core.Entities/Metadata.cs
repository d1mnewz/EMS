using System;

namespace EMS.Core.Entities
{
    public class Metadata
    {
        public DateTime CreatedDateUtc { get; set; }
        public DateTime? ModifiedDateUtc { get; set; }
        public DateTime? DeletedDateUtc { get; set; }

        public Metadata()
        {
            this.CreatedDateUtc = DateTime.Now;
        }
    }
}