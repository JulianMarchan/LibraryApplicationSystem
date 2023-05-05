using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LibraryApplicationSystem.Configuration.Dto;

namespace LibraryApplicationSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LibraryApplicationSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
