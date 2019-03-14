using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpDemoTwo.MultiTenancy.Dto;

namespace AbpDemoTwo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

