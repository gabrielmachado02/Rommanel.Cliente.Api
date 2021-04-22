﻿using NetDevPack.Messaging;
using Rommanel.Cliente.Entities.Core;
using Rommanel.Cliente.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rommanel.Cliente.Entities.Commands
{
    public class ClienteCommand : Command
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string InscricaoEstadual { get; set; }
        public string TipoPessoa { get; set; }

        public Endereco Endereco { get; set; }

    }
}
