using ApplicationLayer.Models.DTOs.OfferCartMessageDTOs;
using AutoMapper;
using DomainLayer;
using DomainLayer.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.OfferCartMessageService
{
    public class OfferCartMessageService : IOfferCartMessageService
    {
        private readonly IOfferCartMessageRepository _offerCartMessageRepository;
        private readonly IMapper _mapper;

        public OfferCartMessageService(IOfferCartMessageRepository offerCartMessageRepository, IMapper mapper)
        {
            _offerCartMessageRepository = offerCartMessageRepository;
            _mapper = mapper;
        }

        public async Task AddMessageAsync(AddOfferCartMessageDTO offerCartMessageDTO)
        {
            OfferCartMessage offerCartMessage = new OfferCartMessage();
            offerCartMessage.IsActive = true;
            _mapper.Map(offerCartMessageDTO, offerCartMessage);
            await _offerCartMessageRepository.AddAsync(offerCartMessage);
        }

        public async Task DeleteMessageAsync(int offerCartMessageId)
        {
            var message = await _offerCartMessageRepository.FindAsync(offerCartMessageId);
            if (message != null)
            {
                message.IsActive = false;
                message.DeleteDate = DateTime.Now;
                await _offerCartMessageRepository.UpdateAsync(message);
            }
        }

        public async Task<List<OfferCartMessage>> GetMessagesByOfferCartIdAsync(int offerCartId)
        {
            return await _offerCartMessageRepository.GetAllInclude()
                .Where(x => x.OfferCartId == offerCartId)
                .OrderBy(x => x.AddedDate)
                .ToListAsync();
        }

        public async Task<List<OfferCartMessage>> GetMessagesByUserIdAsync(int appUserId)
        {
            return await _offerCartMessageRepository.GetAllInclude()
                .Where(x => x.AppUserId == appUserId && x.IsActive == true)
                .OrderBy(x => x.AddedDate)
                .ToListAsync();
        }
    }
}
