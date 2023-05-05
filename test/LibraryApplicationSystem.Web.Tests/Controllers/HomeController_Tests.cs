using System.Threading.Tasks;
using LibraryApplicationSystem.Models.TokenAuth;
using LibraryApplicationSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace LibraryApplicationSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: LibraryApplicationSystemWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}