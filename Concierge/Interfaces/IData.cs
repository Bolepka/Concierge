using Concierge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Interfaces
{
    public interface IData
    {
        Task<Document> Get(Guid id);

        Task Push(Document doc);
    }
}
