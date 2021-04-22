using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rommanel.Cliente.Entities.Core.Events
{
    public class ClienteEventHandler :
      INotificationHandler<ClienteRegisterEvent>
   
    {
        public Task Handle(ClienteRegisterEvent message, CancellationToken cancellationToken)
        {
            // Send some notification e-mail

            return Task.CompletedTask;
        }

        //public Task Handle(CustomerRegisteredEvent message, CancellationToken cancellationToken)
        //{
        //    // Send some greetings e-mail

        //    return Task.CompletedTask;
        //}

        //public Task Handle(CustomerRemovedEvent message, CancellationToken cancellationToken)
        //{
        //    // Send some see you soon e-mail

        //    return Task.CompletedTask;
        //}
    }
}