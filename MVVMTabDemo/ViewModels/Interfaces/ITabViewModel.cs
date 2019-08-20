namespace MVVMTabDemo.ViewModels.Interfaces
{
    interface ITabViewModel
    {
        string Name { get; set; }

        bool IsSelected { get; set; }

        IViewModelBase ViewModel { get; set; }
    }
}
