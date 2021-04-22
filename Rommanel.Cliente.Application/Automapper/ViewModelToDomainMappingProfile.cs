﻿using AutoMapper;
using Rommanel.Cliente.Application.Commands;
using Rommanel.Cliente.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rommanel.Cliente.Application.Automapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteRegisterViewModel, RegisterClienteCommand>()
                .ConstructUsing(c => new RegisterClienteCommand(c.Nome,
                c.Email,c.TipoPessoa,c.InscricaoEstadual, c.DataNascimento, c.CpfCnpj, c.Telefone, c.Endereco));

             CreateMap<UpdateClienteViewModel, UpdateClienteCommand>()
                .ConstructUsing(c => new UpdateClienteCommand(c.Id, c.Nome,
                c.Email, c.DataNascimento, c.CpfCnpj, c.Telefone, c.Endereco));

        }
    }
}
