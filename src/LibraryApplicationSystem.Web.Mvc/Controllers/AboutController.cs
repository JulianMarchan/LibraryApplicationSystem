using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LibraryApplicationSystem.Controllers;

namespace LibraryApplicationSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : LibraryApplicationSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
