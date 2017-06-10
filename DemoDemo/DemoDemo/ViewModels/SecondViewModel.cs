using DemoDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDemo.ViewModels
{
    public class SecondViewModel
    {
        public ObservableCollection<User> UserList { get; set; }

        public SecondViewModel()
        {
            UserList = MainViewModel.UserData.UserList;
        }
    }
}
