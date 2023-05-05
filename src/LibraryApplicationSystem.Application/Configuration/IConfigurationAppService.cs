using System.Threading.Tasks;
using LibraryApplicationSystem.Configuration.Dto;

namespace LibraryApplicationSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
