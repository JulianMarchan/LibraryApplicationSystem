using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryApplicationSystem.Authorization.Accounts.Dto;

namespace LibraryApplicationSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
