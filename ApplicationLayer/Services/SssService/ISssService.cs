using ApplicationLayer.Models.DTOs.SssDTOs;
using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.SssService
{
    public interface ISssService
    {
        Task AddSssAsync(SssCreatedDTO sssCreatedDTO);
        Task DeleteSssAsync(int id);
        Task UpdatedSssAsync(SssUpdatedDTO sssUpdatedDTO);
        Task<IEnumerable<Sss>> GetAllSssAsync();
        Task<Sss> GetSssByIdAsync(int id);
        Task<IEnumerable<Sss>> GetAcceptRequestAdminAsync();
        Task<IEnumerable<Sss>> GetAcceptRequestAdminAcceptedAsync();
    }
}
