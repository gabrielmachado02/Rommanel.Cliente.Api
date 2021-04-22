using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NetDevPack.Mediator;
using Rommanel.Cliente.Application.Commands;
using Rommanel.Cliente.Application.Interfaces;
using Rommanel.Cliente.Application.Services;
using Rommanel.Cliente.Entities.Core.Events;
using Rommanel.Cliente.Infraestructure;
using Rommanel.Cliente.Infraestructure.Bus;
using Rommanel.Cliente.Infraestructure.Repository;
using Rommanel.Cliente.Infraestructure.Repository.EventSourcing;
using Rommanel.Cliente.Infraestructure.Repository.Interfaces;
using System;

namespace Rommanel.Cliente.Ioc
{
    public static class ClienteInjection
    {

        public static void AddInjectionRepository(this IServiceCollection services)
        {
      

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IClienteRepository,ClienteRepository>();
            services.AddScoped<IEventStoreRepository, EventStoreSqlRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
        }

        public static void AddInjectionEvents(this IServiceCollection services)
        {
            services.AddScoped<INotificationHandler<ClienteRegisterEvent>, ClienteEventHandler>();
            services.AddScoped<IRequestHandler<RegisterClienteCommand, ValidationResult>, ClienteCommandHandler>();

        }

        public static void AddInjectionService(this IServiceCollection services)
        {

            services.AddScoped<IClienteAppService, ClienteAppService>();
        }
    }
}
