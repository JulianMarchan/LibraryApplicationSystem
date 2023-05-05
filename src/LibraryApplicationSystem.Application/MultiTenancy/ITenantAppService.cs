using Abp.Application.Services;
using LibraryApplicationSystem.MultiTenancy.Dto;

namespace LibraryApplicationSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

