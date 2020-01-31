using Delivery.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Services.Intrefaces
{
    public interface IDeliveryService
    {
        DeliveryDto Add(DeliveryDto delivery);
        IEnumerable<DeliveryDto> GetAll();
        DeliveryDto Get(Guid? id);
        void Delete(Guid id);
        DeliveryDto Update(DeliveryDto delivery);

        IEnumerable<DeliveryDto> GetAllDelviryFree();

    }
}
