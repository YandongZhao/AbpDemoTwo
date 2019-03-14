using System.Threading.Tasks;
using Abp.Application.Services;
using AbpDemoTwo.Authorization.Accounts.Dto;

namespace AbpDemoTwo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
