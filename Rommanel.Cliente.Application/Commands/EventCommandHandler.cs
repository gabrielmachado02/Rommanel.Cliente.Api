using NetDevPack.Mediator;
using Rommanel.Cliente.Infraestructure;
using Rommanel.Cliente.Infraestructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rommanel.Cliente.Application.Commands
{
   public class EventCommandHandler
    {
        private readonly IMediatorHandler _mediatorHandler;


        public EventCommandHandler(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }
        //public async Task<bool> Commit()
        //{       

        //    return;
        //}
    }
}
