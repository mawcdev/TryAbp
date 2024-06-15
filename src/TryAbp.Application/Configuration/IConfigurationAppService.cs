using System.Threading.Tasks;
using TryAbp.Configuration.Dto;

namespace TryAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
