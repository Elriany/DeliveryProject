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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public CustomerService(ICustomerRepository customerRepository , IUnitOfWork unitOfWork,IMapper mapper)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }        
        public CustomerDto Get(Guid? id)
        {
            if (!id.HasValue)
            {
                throw new NullReferenceException("This Id is not Valid");
            }
            var customer = _customerRepository.Get(id.Value);
            if(customer == null)
            {
                throw new NullReferenceException("This Customer Can not be found");
            }
            return mapper.Map<CustomerDto>(customer);
        }
        public IEnumerable<CustomerDto> GetAll()
        {
            var customers = _customerRepository.GetAll();
            var resultCustomers  =mapper.Map<IEnumerable<CustomerDto>>(customers);
            return resultCustomers;
        }
        public CustomerDto Add(CustomerDto customer)
        {
            customer.Id = Guid.NewGuid();
            var res = mapper.Map<Customer>(customer);
            var cust =  _customerRepository.Add(res);
            _unitOfWork.Commit();
            return mapper.Map<CustomerDto>(cust);
        }
        public void Delete(Guid id)
        {
            if (id == null)
            {
                throw new NullReferenceException("This Id is not Valid");
            }
            else
            {
                _customerRepository.MarkAsDeleted(id);
                _unitOfWork.Commit();
            }            
        }
        public CustomerDto Update(CustomerDto customer)
        {
            var result = mapper.Map<Customer>(customer);
            var cust = _customerRepository.Update(result);
            _unitOfWork.Commit();
            return mapper.Map<CustomerDto>(cust);
        }


    }
}
