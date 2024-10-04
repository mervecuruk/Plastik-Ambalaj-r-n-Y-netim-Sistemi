using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using InfrastructureLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Concrete
{
    public class SssRepository : BaseRepository<Sss>, ISssRepository
    {
        private readonly AppDbContext _context;

        public SssRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Sss>> GetAcceptRequestAdminAcceptedAsync()
        {
            return await _context.Sss.Where(x => x.AdminAccept == true && x.IsActive == true).ToListAsync();
        }

        public async Task<IEnumerable<Sss>> GetAcceptRequestAdminAsync()
        {
            return await _context.Sss.Where(x => x.AdminAccept == false && x.IsActive == true).ToListAsync();
        }

        public async Task<Sss> GetSssByIdAsync(int id)
        {
            return await _context.Sss.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
