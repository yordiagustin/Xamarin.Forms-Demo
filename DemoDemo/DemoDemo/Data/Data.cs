using DemoDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDemo.Data
{
    public class Data
    {
        public ObservableCollection<User> UserList { get; set; }

        public Data()
        {
            UserList = new ObservableCollection<User>()
            {
                new User(){ Name = "Yordi", Email = "yordi@mail.com"}
            };
        }

        public void AddUser(User user)
        {
            UserList.Add(user);
            return;
        }

        public void DeleteUser(User user)
        {
            UserList.Remove(user);
            return;
        }
    }
}
