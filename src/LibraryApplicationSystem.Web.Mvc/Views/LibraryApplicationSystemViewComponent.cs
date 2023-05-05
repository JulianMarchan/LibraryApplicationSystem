using Abp.AspNetCore.Mvc.ViewComponents;

namespace LibraryApplicationSystem.Web.Views
{
    public abstract class LibraryApplicationSystemViewComponent : AbpViewComponent
    {
        protected LibraryApplicationSystemViewComponent()
        {
            LocalizationSourceName = LibraryApplicationSystemConsts.LocalizationSourceName;
        }
    }
}
