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
    public class RegisterClienteCommand : ClienteCommand
    {
  
        public RegisterClienteCommand(string nome, string email,string tipoPessoa,string inscricaoEstadual, DateTime dataNascimento,string cpfCnpj,string telefone,Endereco endereco
           )
        {

            InscricaoEstadual = inscricaoEstadual;
            TipoPessoa = tipoPessoa;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            CpfCnpj = cpfCnpj;
            Telefone = telefone;
            Endereco = endereco;

        }

        public override bool IsValid()
        {
            ValidationResult = new ClienteValidador().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
