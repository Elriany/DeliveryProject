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
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository,IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public UserDto Add(UserDto user)
        {
            var myUser = mapper.Map<User>(user);
            var NewUser = userRepository.Add(myUser);
            unitOfWork.Commit();
            return mapper.Map<UserDto>(NewUser);
        }

        public void Delete(Guid id)
        {
            if (id == null)
            {
                throw new NullReferenceException("This Id is not Valid");
            }
            else
            {
                userRepository.MarkAsDeleted(id);
                unitOfWork.Commit();
            }
        }

        public UserDto Get(Guid? id)
        {
            if (!id.HasValue)
            {
                throw new NullReferenceException("id is not found");
            }
            var user = userRepository.Get(id.Value);
            if(user == null)
            {
                throw new NullReferenceException("this user is not found");
            }
            else
            {
                return mapper.Map<UserDto>(user);
            }
        }

        public IEnumerable<UserDto> GetAll()
        {
            var users = userRepository.GetAll();
            return mapper.Map<IEnumerable<UserDto>>(users);
        }

        public UserDto Update(UserDto user)
        {
            var myuser = mapper.Map<User>(user);
            var updatedUser = userRepository.Update(myuser);
            unitOfWork.Commit();
            return mapper.Map<UserDto>(updatedUser);
        }
    }
}
