using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace LibraryApplicationSystem.Web.Views
{
    public abstract class LibraryApplicationSystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LibraryApplicationSystemRazorPage()
        {
            LocalizationSourceName = LibraryApplicationSystemConsts.LocalizationSourceName;
        }
    }
}
