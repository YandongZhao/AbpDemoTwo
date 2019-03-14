using System.Threading.Tasks;
using Abp.Application.Services;
using AbpDemoTwo.Sessions.Dto;

namespace AbpDemoTwo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
