using System.Windows.Input;

namespace MVVMTabDemo.ViewModels.Interfaces
{
    interface IBarViewModel : IViewModelBase
    {
        string Bar { get; set; }

        int Counter { get; set; }

        string SharedString { get; set; }

        ICommand FooCommand { get; }
    }
}
