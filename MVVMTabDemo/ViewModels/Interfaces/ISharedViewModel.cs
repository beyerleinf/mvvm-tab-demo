namespace MVVMTabDemo.ViewModels.Interfaces
{
    interface ISharedViewModel : IViewModelBase
    {
        string SharedString { get; set; }
    }
}
