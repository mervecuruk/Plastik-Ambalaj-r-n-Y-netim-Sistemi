using ApplicationLayer.Models.DTOs.SssDTOs;
using AutoMapper;
using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.SssService
{
    public class SssService : ISssService
    {
        private readonly ISssRepository _sssRepository;
        private readonly IMapper _mapper;

        public SssService(ISssRepository sssRepository)
        {
            _sssRepository = sssRepository;
        }

        public async Task AddSssAsync(SssCreatedDTO sssCreatedDTO)
        {
            Sss sss = new Sss()
            {
                AskTitle = sssCreatedDTO.AskTitle,
                Content = sssCreatedDTO.Content,
                AddedDate = DateTime.Now,
                IsActive = true,
                AdminAccept = false
            };
            await _sssRepository.AddAsync(sss);

        }

        public async Task DeleteSssAsync(int id)
        {
            Sss result = await _sssRepository.FindAsync(id);
            if (result != null)
            {
                result.IsActive = false;
                result.DeleteDate = DateTime.Now;
                result.AdminAccept = false;
                await _sssRepository.DeleteAsync(result.Id);
            }
        }

        public async Task<IEnumerable<Sss>> GetAcceptRequestAdminAcceptedAsync()
        {
            IEnumerable<Sss> result = await _sssRepository.GetAcceptRequestAdminAcceptedAsync();
            return result;
        }

        public async Task<IEnumerable<Sss>> GetAcceptRequestAdminAsync()
        {
            IEnumerable<Sss> result = await _sssRepository.GetAcceptRequestAdminAsync();
            return result;
        }

        public async Task<IEnumerable<Sss>> GetAllSssAsync()
        {
            IEnumerable<Sss> result = await _sssRepository.GetAllAsync();
            return result;

        }

        public async Task<Sss> GetSssByIdAsync(int id)
        {
            Sss sss = await _sssRepository.GetSssByIdAsync(id);
            return sss;
        }

        public async Task UpdatedSssAsync(SssUpdatedDTO sssUpdatedDTO)
        {
            Sss result = await _sssRepository.FindAsync(sssUpdatedDTO.Id);
            if (result != null)
            {
                result.Content = sssUpdatedDTO.Content;
                result.AskTitle = sssUpdatedDTO.AskTitle;
                result.UpdateDate = DateTime.Now;
                await _sssRepository.UpdateAsync(result);
            }
        }

    }
}

