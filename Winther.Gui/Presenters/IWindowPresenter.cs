using System.Threading.Tasks;

namespace Winther.Gui.Presenters
{
    public interface IWindowPresenter<in TRequest>
    {
        Task UpdateAsync(TRequest request);
    }
}
