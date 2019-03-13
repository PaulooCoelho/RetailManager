using System.Threading.Tasks;

namespace RMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task Authenticate(string username, string password);
    }
}