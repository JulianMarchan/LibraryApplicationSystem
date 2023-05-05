using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryApplicationSystem.Sessions.Dto;

namespace LibraryApplicationSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
