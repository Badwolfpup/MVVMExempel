using MVVMExempel.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MVVMExempel.Commands;

namespace MVVMExempel.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            DataContext = mainViewModel;
        }

        private void changeProperty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}