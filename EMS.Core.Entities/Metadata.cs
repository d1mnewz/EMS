using System;

namespace EMS.Core.Entities
{
    public class Metadata
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Metadata()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}