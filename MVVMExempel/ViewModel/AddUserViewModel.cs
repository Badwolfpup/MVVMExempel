using MVVMExempel.Commands;
using MVVMExempel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMExempel.ViewModel
{
    public class AddUserViewModel
    {
        public string? Name { get; set;}

        public string? Email { get; set;}

        public ICommand AddUserCommand {  get; set; }
        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, canAddUser);
        }

        private bool canAddUser(object ojb)
        {
            return true;
        }

        private void AddUser(object ojb)
        {
            UserManager.AddUser(new User() {  Name = Name, Email = Email });
        }
    }
}
