using MVVMTabDemo.DataModels.Interfaces;

namespace MVVMTabDemo.DataModels
{
    class FooDataModel : IFooDataModel
    {
        public string Foo { get; set; }

        public int Counter { get; set; }
    }
}
