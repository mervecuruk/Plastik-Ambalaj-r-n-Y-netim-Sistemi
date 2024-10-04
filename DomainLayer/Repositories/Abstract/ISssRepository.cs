using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Repositories.Abstract
{
    public interface ISssRepository : IBaseRepository<Sss>
    {
        Task<Sss> GetSssByIdAsync(int id);
        Task<IEnumerable<Sss>> GetAcceptRequestAdminAsync();
        Task<IEnumerable<Sss>> GetAcceptRequestAdminAcceptedAsync();
    }
}
