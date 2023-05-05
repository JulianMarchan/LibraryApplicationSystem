using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LibraryApplicationSystem.Controllers
{
    public abstract class LibraryApplicationSystemControllerBase: AbpController
    {
        protected LibraryApplicationSystemControllerBase()
        {
            LocalizationSourceName = LibraryApplicationSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
