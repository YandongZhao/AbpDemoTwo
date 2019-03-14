using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpDemoTwo.Configuration.Dto;

namespace AbpDemoTwo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpDemoTwoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
