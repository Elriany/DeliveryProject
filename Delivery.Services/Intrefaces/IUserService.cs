using Delivery.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Services.Intrefaces
{
    public interface IUserService
    {
        UserDto Add(UserDto delivery);
        IEnumerable<UserDto> GetAll();
        UserDto Get(Guid? id);
        void Delete(Guid id);
        UserDto Update(UserDto delivery);
    }
}
