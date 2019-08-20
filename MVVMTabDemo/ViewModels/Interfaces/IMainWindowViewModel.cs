using System.Collections.ObjectModel;

namespace MVVMTabDemo.ViewModels.Interfaces
{
    interface IMainWindowViewModel
    {
        ObservableCollection<ITabViewModel> TabItems { get; set; }
    }
}
