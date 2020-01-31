using Delivery.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Services.Intrefaces
{
    public interface IOfferService
    {
        OffersDto Add(OffersDto delivery);
        IEnumerable<OffersDto> GetAll();
        OffersDto Get(Guid? id);
        void Delete(Guid id);
        OffersDto Update(OffersDto delivery);
    }
}
