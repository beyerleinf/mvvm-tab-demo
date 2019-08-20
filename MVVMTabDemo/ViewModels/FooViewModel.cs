using MVVMTabDemo.DataModels;
using MVVMTabDemo.DataModels.Interfaces;
using MVVMTabDemo.Shared;
using MVVMTabDemo.ViewModels.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MVVMTabDemo.ViewModels
{
    class FooViewModel : IFooViewModel
    {
        private ISharedViewModel _sharedViewModel;
        private IFooDataModel _dataModel;

        private ICommand _fooCommand;

        public FooViewModel(ISharedViewModel sharedViewModel)
        {
            this._dataModel = new FooDataModel() { Foo = "Foo" };

            this._sharedViewModel = sharedViewModel;
            this._sharedViewModel.PropertyChanged += this.SharedViewModelPropertyChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand FooCommand => this._fooCommand ?? (this._fooCommand = new RelayCommand<string>(this.FooFunction));

        public string Foo
        {
            get { return this._dataModel.Foo; }
            set
            {
                if (this._dataModel.Foo != value)
                {
                    this._dataModel.Foo = value;
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

        private void FooFunction(string _)
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
