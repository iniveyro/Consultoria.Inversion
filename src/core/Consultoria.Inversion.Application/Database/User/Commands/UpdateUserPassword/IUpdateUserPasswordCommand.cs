using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultoria.Inversion.Application.Database.User.Commands.UpdateUserPassword
{
    public interface IUpdateUserPasswordCommand
    {
        Task<bool> Execute (UpdateUserPasswordModel model);
    }
}