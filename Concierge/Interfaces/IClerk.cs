using Concierge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Interfaces
{
    /// <summary>
    /// Main API interface
    /// </summary>
    public interface IClerk
    {
        Document Get(Guid id);
        void Set(Document id);
    }
}
