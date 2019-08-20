using System.Windows.Input;

namespace MVVMTabDemo.ViewModels.Interfaces
{
    interface IFooViewModel : IViewModelBase
    {
        string Foo { get; set; }

        int Counter { get; set; }

        string SharedString { get; set; }

        ICommand FooCommand { get; }
    }
}
