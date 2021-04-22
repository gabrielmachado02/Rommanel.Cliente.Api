using AutoMapper;
using FluentValidation.Results;
using Rommanel.Cliente.Application.ViewModels;
using Rommanel.Cliente.Entities.Entities;
using Rommanel.Cliente.Infraestructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rommanel.Cliente.Application.Interfaces
{

        public interface IClienteAppService     
        {
        IEnumerable<Clientes> GetAll();

        Task<ClienteListaViewModel> GetById(Guid id);

        Task<ValidationResult> AddAsync(ClienteRegisterViewModel customerViewModel);

        Task<ValidationResult> UpdateAsync(UpdateClienteViewModel entity);

        Task<ValidationResult> Remove(Guid id);
    }
}
