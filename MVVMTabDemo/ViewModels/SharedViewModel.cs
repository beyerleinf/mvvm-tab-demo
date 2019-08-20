using MVVMTabDemo.DataModels;
using MVVMTabDemo.ViewModels.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMTabDemo.ViewModels
{
    class SharedViewModel : ISharedViewModel
    {
        private SharedDataModel _dataModel;

        public SharedViewModel()
        {
            this._dataModel = new SharedDataModel() { SharedString = "Shared String" };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string SharedString
        {
            get { return this._dataModel.SharedString; }
            set
            {
                if (this._dataModel.SharedString != value)
                {
                    this._dataModel.SharedString = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
