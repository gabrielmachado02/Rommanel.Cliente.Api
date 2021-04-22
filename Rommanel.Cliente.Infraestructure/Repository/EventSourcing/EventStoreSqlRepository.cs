﻿using Microsoft.EntityFrameworkCore;
using Rommanel.Cliente.Entities.Core.Events;
using Rommanel.Cliente.Infraestructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rommanel.Cliente.Infraestructure.Repository.EventSourcing
{
    public class EventStoreSqlRepository : IEventStoreRepository
    {
        private readonly EventStoreSqlContext _context;

        public EventStoreSqlRepository(EventStoreSqlContext context)
        {
            _context = context;
        }

        public async Task<IList<StoredEvent>> All(Guid aggregateId)
        {
            return await (from e in _context.StoredEvent where e.AggregateId == aggregateId select e).ToListAsync();
        }

        public void Store(StoredEvent theEvent)
        {
            _context.StoredEvent.Add(theEvent);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
