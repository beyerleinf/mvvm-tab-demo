using MVVMTabDemo.ViewModels;
using System.Windows;

namespace MVVMTabDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }
    }
}
