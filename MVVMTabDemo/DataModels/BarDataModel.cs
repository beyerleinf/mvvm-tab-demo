using MVVMTabDemo.DataModels.Interfaces;

namespace MVVMTabDemo.DataModels
{
    class BarDataModel : IBarDataModel
    {
        public string Bar { get; set; }

        public int Counter { get; set; }
    }
}
