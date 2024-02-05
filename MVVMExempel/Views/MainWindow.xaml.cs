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
using MVVMExempel.Model;
using System.ComponentModel;

namespace MVVMExempel.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private int _getProp;

        public int GetProp
        {
            get { return _getProp; }
            set
            {
                if (_getProp != value )
                {
                    _getProp = value;
                    OnPropertyChanged(nameof(GetProp));
                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            DataContext = mainViewModel;
            GetProp = 12;
            propertyText.DataContext = this;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;



        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserList.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var user = obj as User;
            return user.Name.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }

        private void changeProperty_Click(object sender, RoutedEventArgs e)
        {
            GetProp++;
        }
    }
}