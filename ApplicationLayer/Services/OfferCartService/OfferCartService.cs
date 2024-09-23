using ApplicationLayer.Models.DTOs.OfferCartDTOs;
using AutoMapper;
using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.OfferCartService
{
    public class OfferCartService : IOfferCartService
    {
        private readonly IOfferCartRepository _offerCartRepository;
        private readonly IMapper _mapper;

        public OfferCartService(IOfferCartRepository offerCartRepository, IMapper mapper)
        {
            _offerCartRepository = offerCartRepository;
            _mapper = mapper;
        }

        public async Task<OfferCart> AddOfferCartAsync(AddOfferCartDTO offerCart)
        {
            OfferCart newOfferCart = new OfferCart();
            _mapper.Map(offerCart, newOfferCart);
            return await _offerCartRepository.AddOfferCartAsync(newOfferCart);
        }

        public async Task AddToCartAsync(AddOfferCartDTO cart)
        {
            OfferCart newOfferCart = new OfferCart();
            _mapper.Map(cart, newOfferCart);
            await _offerCartRepository.AddOfferCartAsync(newOfferCart);
        }

        public async Task<bool> ApproveOfferByAdminAsync(int offerCartId)
        {
            return await _offerCartRepository.ApproveOfferByAdminAsync(offerCartId);
        }

        public async Task<bool> ApproveSamplePreparationAsync(int offerCartId)
        {
            return await _offerCartRepository.ApproveSamplePreparationAsync(offerCartId);
        }

        public async Task<bool> DeleteOfferCartAsync(int offerCartId)
        {
            OfferCart offerCart = await _offerCartRepository.FindAsync(offerCartId);
            if (offerCart != null)
            {
                await _offerCartRepository.DeleteOfferCartAsync(offerCart.OfferCartId);
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<OfferCart>> GetAllByUserIdAsync(int appuserId)
        {
            return await _offerCartRepository.GetAllInclude().Where(x => x.AppUserId == appuserId).ToListAsync();
        }

        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsAsync()
        {
            return await _offerCartRepository.GetAllOfferCartsAsync();
        }

        public async Task<OfferCart> GetOfferCartByIdAsync(int offerCartId)
        {
            OfferCart offerCart = await _offerCartRepository.GetOfferCartByIdAsync(offerCartId);
            if (offerCart != null)
            {
                return offerCart;
            }
            else
            {
                throw new Exception("OfferCart Not Found");
            }
        }

        public async Task<List<OfferCart>> GetOfferCartByKeywordAndUserId(string keyword, int appuserId)
        {
            return await _offerCartRepository.GetAllInclude().Where(x => x.AppUserId == appuserId && x.Product.ProductName.ToLower().Contains(keyword.ToLower())).ToListAsync();
        }

        public async Task<bool> RemoveAllProductsForUserAsync(int userId)
        {
            var user = await _offerCartRepository.FindAsync(userId);
            if (user != null)
            {
                await _offerCartRepository.RemoveAllProductsForUserAsync(userId);
                return true;
            }
            return false;
        }

        public async Task<bool> SetFinalizationAsync(int offerCartId)
        {
            return await _offerCartRepository.SetFinalizationAsync(offerCartId);
        }

        public async Task<bool> SetMoldProductionAsync(int offerCartId)
        {
            return await _offerCartRepository.SetMoldProductionAsync(offerCartId);
        }

        public async Task<bool> ShowSampleButtonAsync(int offerCartId)
        {
            return await _offerCartRepository.ShowSampleButtonAsync(offerCartId);
        }

        public async Task<OfferCart> UpdateOfferCartAsync(UpdateOfferCartDTO offerCart)
        {
            OfferCart oldOfferCart = await _offerCartRepository.FindAsync(offerCart.OfferCartId);
            _mapper.Map(offerCart, oldOfferCart);
            return await _offerCartRepository.UpdateOfferCartAsync(oldOfferCart);
        }
    }
}
