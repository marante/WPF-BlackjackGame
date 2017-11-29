using PropertyChanged;
using System.ComponentModel;

namespace Assignment_5.ViewModels
{
    /// <inheritdoc />
    /// <summary>
    ///     Base view model that fires the property changed events for us. 
    ///     No need to rewrite the propery changed event for every view model.
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
