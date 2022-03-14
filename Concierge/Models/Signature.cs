using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Models
{
    public class Signature
    {
        public Guid Id { get; set; }

        public Guid MemberId { get; set; }

        public string Title { get; set; }

    }
}
