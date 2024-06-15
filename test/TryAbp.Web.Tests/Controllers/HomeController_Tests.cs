using System.Threading.Tasks;
using TryAbp.Models.TokenAuth;
using TryAbp.Web.Controllers;
using Shouldly;
using Xunit;

namespace TryAbp.Web.Tests.Controllers
{
    public class HomeController_Tests: TryAbpWebTestBase
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