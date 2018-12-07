using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BookList.MultiTenancy.Dto;

namespace BookList.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
