using MVVMTabDemo.ViewModels.Interfaces;

namespace MVVMTabDemo.ViewModels
{
    class TabViewModel : ITabViewModel
    {
        public string Name { get; set; }

        public bool IsSelected { get; set; }

        public IViewModelBase ViewModel { get; set; }
    }
}
