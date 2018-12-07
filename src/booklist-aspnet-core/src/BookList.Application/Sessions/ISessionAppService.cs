using System.Threading.Tasks;
using Abp.Application.Services;
using BookList.Sessions.Dto;

namespace BookList.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
