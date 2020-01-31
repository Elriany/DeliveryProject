using Delivery.RepoInterfaces;
using Delivery.Repository;
using Delivery.Services.Implementations;
using Delivery.Services.Intrefaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.UI.DependencyResolver
{
    public class RepositoryResolver
    {
        public static void RepositoryResolve(IServiceCollection service)
        {
            service.AddScoped<DbContext, ApplicationContext>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();

            //DI Repositories
            service.AddTransient<ICustomerRepository, CustomerRepository>();
            service.AddTransient<IDeliveryRepository, DeliveryRepository>();
            service.AddTransient<IOrderRepository, OrderRepository>();
            service.AddTransient<IOfferRepository, OfferRepository>();
            service.AddTransient<IUserRepository, UserRepository>();

            //DI Services
            service.AddTransient<ICustomerService, CustomerService>();
            service.AddTransient<IDeliveryService, DeliveryService>();
            service.AddTransient<IOrderService, OrderService>();
            service.AddTransient<IOfferService, OfferService>();
            service.AddTransient<IUserService, UserService>();


        }
    }
}
