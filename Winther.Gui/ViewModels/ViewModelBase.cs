namespace Winther.Gui.ViewModels
{
    public class ViewModelBase
    {
        public delegate void ModelChangeDelegate(string fieldName, object value);

        private event ModelChangeDelegate ModelChanged;


        protected virtual void OnModelChanged(string fieldname, object value)
        {
            ModelChanged?.Invoke(fieldname, value);
        }
    }
}
