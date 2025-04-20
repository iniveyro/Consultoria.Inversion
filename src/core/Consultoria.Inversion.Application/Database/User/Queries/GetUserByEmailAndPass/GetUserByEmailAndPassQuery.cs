using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.User.Queries.GetUserByEmailAndPass
{
    public class GetUserByEmailAndPassQuery : IGetUserByEmailAndPassQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetUserByEmailAndPassQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<GetUserByEmailAndPassModel> Execute(string Email, string Password)
        {
            var UserInstance = await _databaseService.User.FirstOrDefaultAsync(x=> x.Email == Email && x.Password == Password);
            return _mapper.Map<GetUserByEmailAndPassModel>(UserInstance);
        }
    }
}