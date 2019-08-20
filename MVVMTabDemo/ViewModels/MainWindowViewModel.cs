using MVVMTabDemo.ViewModels.Interfaces;
using System.Collections.ObjectModel;

namespace MVVMTabDemo.ViewModels
{
    class MainWindowViewModel : IMainWindowViewModel
    {
        private ISharedViewModel _sharedViewModel;

        public MainWindowViewModel()
        {
            this._sharedViewModel = new SharedViewModel();

            this.TabItems = new ObservableCollection<ITabViewModel>();
            this.TabItems.Add(new TabViewModel() { Name = "Foo", IsSelected = true, ViewModel = new FooViewModel(this._sharedViewModel) });
            this.TabItems.Add(new TabViewModel() { Name = "Bar", IsSelected = false, ViewModel = new BarViewModel(this._sharedViewModel) });
        }

        public ObservableCollection<ITabViewModel> TabItems { get; set; }
    }
}
