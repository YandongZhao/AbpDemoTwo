using System.Threading.Tasks;
using AbpDemoTwo.Configuration.Dto;

namespace AbpDemoTwo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
