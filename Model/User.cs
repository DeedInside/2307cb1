using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _2307cb1.Model
{
    /// <summary>
    /// public commit
    /// </summary>
    public class User: INotifyPropertyChanged
    {
        /// <summary>
        /// commit
        /// </summary>
        /// <param name="name">commit params 1</param>
        /// <param name="email">commit params 2</param>
        /// <param name="password">commit params 3</param>
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
        /// <summary>
        ///  indentity user
        /// </summary>
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        private DateTime date = DateTime.Now;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public override string ToString()
        {
            return $"{Name} - {Date} - {Email} - {Password}";
        }
    }
}
