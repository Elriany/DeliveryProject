using AutoMapper;
using Delivery.Core;
using Delivery.Core.DTO;
using Delivery.RepoInterfaces;
using Delivery.Services.Intrefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Services.Implementations
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository offerRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public OfferService(IOfferRepository offerRepository,IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.offerRepository = offerRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public OffersDto Add(OffersDto newOffer)
        {
            var offer = mapper.Map<Offer>(newOffer);
            var addedOffer = offerRepository.Add(offer);
            unitOfWork.Commit();
            return mapper.Map<OffersDto>(addedOffer);
        }

        public void Delete(Guid id)
        {
            if (id == null)
            {
                throw new NullReferenceException("This Id is not Valid");
            }
            else
            {
                offerRepository.MarkAsDeleted(id);
                unitOfWork.Commit();
            }            
        }

        public OffersDto Get(Guid? id)
        {
            if (!id.HasValue)
            {
                throw new NullReferenceException("This Id is not Valid");
            }
            var myoffer = offerRepository.Get(id.Value);
            if(myoffer == null)
            {
                throw new NullReferenceException("This Offer Can not be found");
            }
            return mapper.Map<OffersDto>(myoffer);
        }

        public IEnumerable<OffersDto> GetAll()
        {
            var offers = offerRepository.GetAll();
            return mapper.Map<IEnumerable<OffersDto>>(offers);
        }

        public OffersDto Update(OffersDto offer)
        {
            var myOffer = mapper.Map<Offer>(offer);
            var newOffer = offerRepository.Update(myOffer);
            unitOfWork.Commit();
            return mapper.Map<OffersDto>(newOffer);
        }
    }
}
