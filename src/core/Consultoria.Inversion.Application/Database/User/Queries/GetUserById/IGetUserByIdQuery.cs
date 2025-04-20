using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultoria.Inversion.Application.Database.User.Queries.GetUserById
{
    public interface IGetUserByIdQuery
    {
        Task<GetUserByIdModel> Execute(int UserId);
    }
}