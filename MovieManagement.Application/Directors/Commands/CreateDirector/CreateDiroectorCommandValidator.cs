using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Application.Directors.Commands.CreateDirector
{
    public class CreateDiroectorCommandValidator : AbstractValidator<CreateDirectorCommand>
    {
        public CreateDiroectorCommandValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(15);
        }
    }
}
