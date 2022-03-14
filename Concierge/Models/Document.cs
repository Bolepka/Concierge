using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Models
{
    public class Document
    {
        public Guid Id { get; set; }

        public Guid DocTypeId { get; set; }

        public string Hash { get; set; }

        public ushort Version { get; set; }

        // Validate array contains?
        public string Status { get; set; }

        public virtual ICollection<Signature> Signatures { get; set; }
    }
}
