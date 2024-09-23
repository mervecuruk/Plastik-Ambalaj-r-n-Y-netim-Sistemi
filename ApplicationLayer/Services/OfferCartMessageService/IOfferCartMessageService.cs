using ApplicationLayer.Models.DTOs.OfferCartMessageDTOs;
using DomainLayer;

namespace ApplicationLayer.Services.OfferCartMessageService
{
    public interface IOfferCartMessageService
    {
        Task AddMessageAsync(AddOfferCartMessageDTO offerCartMessageDTO);
        Task DeleteMessageAsync(int offerCartMessageId);
        Task<List<OfferCartMessage>> GetMessagesByOfferCartIdAsync(int offerCartId);
        Task<List<OfferCartMessage>> GetMessagesByUserIdAsync(int appUserId);
    }
}