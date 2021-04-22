using Microsoft.EntityFrameworkCore;
using Rommanel.Cliente.Entities.Entities;
using Rommanel.Cliente.Infraestructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rommanel.Cliente.Infraestructure.Repository
{
    public class ClienteRepository : BaseRepository<Clientes>, IClienteRepository
    {
        public ClienteRepository(ClienteDbContext clienteContext) : base(clienteContext)
        {
        }

        public async Task<Clientes> ObterCLientePorEmail(string email) {

            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Email == email);

        }

        public async Task<Clientes> ObterClientePorCnpj(string cpfCnpj)
        {

            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.CpfCnpj == cpfCnpj);

        }

    }
}
