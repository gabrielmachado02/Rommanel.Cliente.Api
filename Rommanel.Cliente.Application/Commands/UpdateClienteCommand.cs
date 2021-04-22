﻿using Rommanel.Cliente.Application.Commands.Validations;
using Rommanel.Cliente.Entities.Commands;
using Rommanel.Cliente.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rommanel.Cliente.Application.Commands
{
   public class UpdateClienteCommand : ClienteCommand
    {
        public UpdateClienteCommand(Guid id, string nome, string email, DateTime dataNascimento, string cpfCnpj, string telefone, Endereco endereco
           )
        {
            Id = Id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            CpfCnpj = cpfCnpj;
            Telefone = telefone;
            

        }



        public override bool IsValid()
        {
            ValidationResult = new ClienteValidador().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
