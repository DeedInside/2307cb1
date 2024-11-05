using _2307cb1.Model;
using _2307cb1.ViewModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace _2307cb1
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> Users { set; get; }
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

            BiInput.DataContext = new InputVM();
            TiList.DataContext = new TiListViewVM();

            check_1.IsChecked = true;

            
            this.DataContext = this;
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            str = TestTextBox.Text.ToString();
            MessageBox.Show(str);
        }

    }
}