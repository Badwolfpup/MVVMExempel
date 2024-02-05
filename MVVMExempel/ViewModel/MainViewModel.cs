using MVVMExempel.Commands;
using MVVMExempel.Model;
using MVVMExempel.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMExempel.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public ICommand showWindowCommand {  get; set; }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();
            showWindowCommand = new RelayCommand(ShowWindow, canShowWindow);
        }

        private bool canShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;
            AddUser addUserWindow = new AddUser();
            addUserWindow.Owner = mainWindow;
            addUserWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner; 
            addUserWindow.Show();
        }
    }
}
