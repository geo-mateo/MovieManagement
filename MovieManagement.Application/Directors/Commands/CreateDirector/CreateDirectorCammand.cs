using MediatR;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Application.Directors.Commands.CreateDirector
{
    public  class CreateDirectorCammand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DoB { get; set; }

        public string PlaceOfBirth { get; set; }
    }
}
