using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultoria.Inversion.Application.Database.User.Commands
{
    public class CreateUserModel
    {
        public required string NombApe {get;set;}
        public required string Email {get;set;}
        public required string Password {get;set;}
        public int DNI {get;set;}
    }
}