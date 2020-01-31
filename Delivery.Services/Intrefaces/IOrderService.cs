using Delivery.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Services.Intrefaces
{
    public interface IOrderService
    {
        OrderDto Add(OrderDto delivery);
        IEnumerable<OrderDto> GetAll();
        OrderDto Get(Guid? id);
        void Delete(Guid id);
        OrderDto Update(OrderDto delivery);
    }
}
