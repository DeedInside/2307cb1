using _2307cb1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;
using System.Reflection.Emit;
using _2307cb1.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _2307cb1.ViewModel
{
    internal class TiListViewVM
    {
        private ObservableCollection<string> listUserName;
        public ObservableCollection<string> ListUserName
        {
            get { return listUserName; }
            set { listUserName = value; }
        }
        public ObservableCollection<User> Users { set; get; }
        ApplicationContext _context = new ApplicationContext();
        public TiListViewVM()
        {
            _context.Database.EnsureCreated();
            _context.Users.Load();
            Users = _context.Users.Local.ToObservableCollection();

            ListUserName = toStrUserName(Users);
        }
        public ObservableCollection<string> toStrUserName(ObservableCollection<User> users)
        {
            ObservableCollection<string> result = new ObservableCollection<string>();

            foreach (var item in users)
            {
                result.Add(item.Name);
            }
            return result;
        }
        
        private RelayCommand listViewSelection;
        public RelayCommand ListViewSelection
        {
            get
            {
                return listViewSelection ??
                (listViewSelection = new RelayCommand(obj =>
                {
                    User user = obj as User;
                    MessageBox.Show(user.ToString());
                }));
            }
        }

        private RelayCommand save_user;
        public RelayCommand Save_user
        {
            get
            {
                return save_user ??
                (save_user = new RelayCommand(obj =>
                {
                    User user = new User("Name", "@mail.ru", "password");

                    _context.Users.Add(user);
                    _context.SaveChanges();
                    int a = 0;
                    int b = 5;

                    swap(ref a, ref b);
                    MessageBox.Show($"a={a} b={b}");
                }));
            }
        }
        public void swap(ref int a, ref int b)
        {
            int num = a;
            a = b;
            b = num;
        }
    }
}
