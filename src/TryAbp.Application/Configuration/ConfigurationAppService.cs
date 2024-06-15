using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TryAbp.Configuration.Dto;

namespace TryAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TryAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
