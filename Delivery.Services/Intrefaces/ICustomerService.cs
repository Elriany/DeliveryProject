using Delivery.Core;
using Delivery.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Services.Intrefaces
{
    public interface ICustomerService
    {
        CustomerDto Add(CustomerDto customer);
        IEnumerable<CustomerDto> GetAll();
        CustomerDto Get(Guid? id);
        void Delete(Guid id);
        CustomerDto Update(CustomerDto customer);

    }
}
