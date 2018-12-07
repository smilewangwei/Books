using System.Threading.Tasks;
using BookList.Configuration.Dto;

namespace BookList.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
