using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpDemoTwo.Controllers
{
    public abstract class AbpDemoTwoControllerBase: AbpController
    {
        protected AbpDemoTwoControllerBase()
        {
            LocalizationSourceName = AbpDemoTwoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
