using NetDevPack.Data;
using Rommanel.Cliente.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rommanel.Cliente.Infraestructure.Repository.Interfaces
{
    public interface IClienteRepository : IRepository<Clientes>, IBaseRepository<Clientes>
    {
         Task<Clientes> ObterCLientePorEmail(string email);

         Task<Clientes> ObterClientePorCnpj(string cpfCnpj);
    }
}
