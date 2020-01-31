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
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public OrderService(IOrderRepository orderRepository,IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.orderRepository = orderRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.mapper = mapper;
        }
        public OrderDto Add(OrderDto order)
        {
            order.Id = Guid.NewGuid();
            var Neworder = mapper.Map<Order>(order);
            var orderadded = orderRepository.Add(Neworder);
            unitOfWork.Commit();
            return mapper.Map<OrderDto>(orderadded);
        }

        public void Delete(Guid id)
        {
            if (id == null)
            {
                throw new NullReferenceException("This Id is not Valid");
            }
            else
            {
                orderRepository.MarkAsDeleted(id);
                unitOfWork.Commit();
            }
        }

        public OrderDto Get(Guid? id)
        {
            if (!id.HasValue)
            {
                throw new NullReferenceException("This Id is not Valid");
            }
            var order = orderRepository.Get(id.Value);
            if (order == null)
            {
                throw new NullReferenceException("This Order Can not be found");
            }
            return mapper.Map<OrderDto>(order);
        }

        public IEnumerable<OrderDto> GetAll()
        {
            var orders = orderRepository.GetAll();
            return mapper.Map<IEnumerable<OrderDto>>(orders);
        }

        public OrderDto Update(OrderDto order)
        {
            var ordermapped = mapper.Map<Order>(order);
            var updatedOrder = orderRepository.Update(ordermapped);
            unitOfWork.Commit();
            return mapper.Map<OrderDto>(updatedOrder);
        }
    }
}
