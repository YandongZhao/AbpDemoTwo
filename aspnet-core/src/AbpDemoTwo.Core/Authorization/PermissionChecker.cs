using Abp.Authorization;
using AbpDemoTwo.Authorization.Roles;
using AbpDemoTwo.Authorization.Users;

namespace AbpDemoTwo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
