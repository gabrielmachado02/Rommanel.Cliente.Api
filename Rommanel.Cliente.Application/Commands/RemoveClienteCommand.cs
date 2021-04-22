using Rommanel.Cliente.Application.Commands.Validations;
using Rommanel.Cliente.Entities.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rommanel.Cliente.Application.Commands
{
   public class RemoveClienteCommand: ClienteCommand
    {
        public RemoveClienteCommand(Guid id)
        {
            Id = id;
        }


        public override bool IsValid()
        {
            ValidationResult = new RemoveClienteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
