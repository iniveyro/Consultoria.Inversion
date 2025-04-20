using System.Diagnostics.Contracts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.User.Queries.GetUserById
{
    public class GetUserByIdQuery : IGetUserByIdQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetUserByIdQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService=databaseService;
            _mapper=mapper;
        }

        public async Task<GetUserByIdModel> Execute(int UserId)
        {
            var UserInstance = await _databaseService.User.FirstOrDefaultAsync(x=> x.UserId == UserId);
            return _mapper.Map<GetUserByIdModel>(UserInstance);
        }
    }
}