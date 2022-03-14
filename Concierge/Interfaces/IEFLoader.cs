using Concierge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Interfaces
{
    public interface IEFLoader
    {
        /// <summary>
        /// Get EF tracking Instance
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Document> GetDocForProcess(Guid id);
        
        /// <summary>
        /// Upsert changes
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        Task SaveChanges(Document doc);
    }
}
