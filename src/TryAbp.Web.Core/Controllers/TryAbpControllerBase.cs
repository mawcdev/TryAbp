using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TryAbp.Controllers
{
    public abstract class TryAbpControllerBase: AbpController
    {
        protected TryAbpControllerBase()
        {
            LocalizationSourceName = TryAbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
