using System.Threading.Tasks;

namespace Winther.Gui.Presenters
{
    public interface IWindowPresenter<in TModel>
    {
        Task UpdateAsync(TModel model);
    }
}
