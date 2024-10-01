using _2307cb1.Model;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using System.Windows.Controls;

namespace _2307cb1
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> users { set; get; }
        private int b;
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value >= 0)
                {
                    b = value;
                }
            }
        }

        int a = 9;
        
        public string str { get; set; } = "1234567";

        public MainWindow()
        {
            InitializeComponent();
            users = new ObservableCollection<User>()
            {
                new User("Name 1", "Email", "Pass"),
                new User("Name 2", "Email", "Pass"),
                new User("Name 3", "Email", "Pass"),
                new User("Name 4", "Email", "Pass"),
            };

            ListBoxUser.ItemsSource = users;

            check_1.IsChecked = true;

            ComboBoxUserName.ItemsSource = toStrUserName(users);
            this.DataContext = this;
        }

        private void bt_out_text(object sender, RoutedEventArgs e)
        {

            Button bt = sender as Button;
            bt.Content = "туц туц туц";
            lb.Content = tb_1.Text;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox check = sender as CheckBox;
            if (check.IsChecked == true)
            {
                stackPanObr.Visibility = Visibility.Visible;
                MessageBox.Show(stackPanObr.Visibility.ToString());
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            stackPanObr.Visibility = Visibility.Collapsed;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rad = sender as RadioButton;

            if (rad.IsChecked == true)
            {
                MessageBox.Show(rad.Content.ToString());
            }
        }

        private void Check_listBox(object sender, SelectionChangedEventArgs e)
        {
            ListBox list = sender as ListBox;

            if( list != null)
            {
                MessageBox.Show(list.SelectedItem.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User("new name", "new Email", "new pass"));
            ListBoxUser.Items.Refresh();
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            str = TestTextBox.Text.ToString();
            MessageBox.Show(str);
        }

        private void Button_save_user(object sender, RoutedEventArgs e)
        {
            users.Add(new User("new name", "new Email", "new Password"));
        }
    }
}