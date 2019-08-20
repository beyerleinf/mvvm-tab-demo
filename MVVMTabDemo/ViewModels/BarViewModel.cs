using MVVMTabDemo.DataModels;
using MVVMTabDemo.DataModels.Interfaces;
using MVVMTabDemo.Shared;
using MVVMTabDemo.ViewModels.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MVVMTabDemo.ViewModels
{
    class BarViewModel : IBarViewModel
    {
        private ISharedViewModel _sharedViewModel;
        private IBarDataModel _dataModel;

        private ICommand _fooCommand;

        public BarViewModel(ISharedViewModel sharedViewModel)
        {
            this._dataModel = new BarDataModel() { Bar = "Bar" };

            this._sharedViewModel = sharedViewModel;
            this._sharedViewModel.PropertyChanged += this.SharedViewModelPropertyChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand FooCommand => this._fooCommand ?? (this._fooCommand = new RelayCommand<string>(this.BarFunction));

        public string Bar
        {
            get { return this._dataModel.Bar; }
            set
            {
                if (this._dataModel.Bar != value)
                {
                    this._dataModel.Bar = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public int Counter
        {
            get { return this._dataModel.Counter; }
            set
            {
                if (this._dataModel.Counter != value)
                {
                    this._dataModel.Counter = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public string SharedString
        {
            get { return this._sharedViewModel.SharedString; }
            set
            {
                if (this._sharedViewModel.SharedString != value)
                {
                    this._sharedViewModel.SharedString = value;
                }
            }
        }

        private void BarFunction(string _)
        {
            this.Counter++;
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SharedViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != null)
            {
                this.NotifyPropertyChanged(e.PropertyName);
            }
        }
    }
}
