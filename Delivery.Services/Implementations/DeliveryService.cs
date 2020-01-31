using AutoMapper;
using Delivery.Core.DTO;
using Delivery.RepoInterfaces;
using Delivery.Services.Intrefaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Delivery.Services.Implementations
{
    public class DeliveryService : IDeliveryService
    {

        private readonly IDeliveryRepository _delviryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;
        public DeliveryService(IDeliveryRepository deliveryRepository, IUnitOfWork UnitOfWork,IMapper Mapper)
        {
            this._delviryRepository = deliveryRepository;
            this._unitOfWork = UnitOfWork;
            this.mapper = Mapper;

        }
        public DeliveryDto Add(DeliveryDto delivery)
        {
            delivery.Id = Guid.NewGuid();
            var Newdelvery = mapper.Map<Delivery.Core.Delivery>(delivery);
            var delvery = _delviryRepository.Add(Newdelvery);
            _unitOfWork.Commit();
            return mapper.Map<DeliveryDto>(delivery);
        }

        public void Delete(Guid id)
        {
            if (id == null)
            {
                throw new NullReferenceException("This Id is not Valid");
            }
            else
            {
                _delviryRepository.MarkAsDeleted(id);
                _unitOfWork.Commit();
            }            
        }

        public DeliveryDto Get(Guid? id)
        {
            if (!id.HasValue)
            {
                throw new NullReferenceException("This Id is not Valid");
            }
            var delvery = _delviryRepository.Get(id.Value);
            if (delvery == null)
            {
                throw new NullReferenceException("This Customer Can not be found");
            }
            return mapper.Map<DeliveryDto>(delvery);
        }

        public IEnumerable<DeliveryDto> GetAll()
        {
            var delveries = _delviryRepository.GetAll();
            return mapper.Map<IEnumerable<DeliveryDto>>(delveries);
        }

        public IEnumerable<DeliveryDto> GetAllDelviryFree()
        {
            var delveriesFree = _delviryRepository.Filter(a => a.IsFree == true).ToList();
            return mapper.Map<IEnumerable<DeliveryDto>>(delveriesFree);
        }

        public DeliveryDto Update(DeliveryDto delivery)
        {
            var delvery = mapper.Map<Delivery.Core.Delivery>(delivery);
            var updatedDelvery = _delviryRepository.Update(delvery);
            _unitOfWork.Commit();
            return mapper.Map<DeliveryDto>(updatedDelvery);

        }
    }
}
