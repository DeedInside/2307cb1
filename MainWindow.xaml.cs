using System.Windows;
using System.Windows.Controls;

namespace _2307cb1
{
    public partial class MainWindow : Window
    {
        private int b;
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if( value >= 0)
                {
                    b = value;
                }
            }
        }

        int a = 9;
        public MainWindow()
        {
            InitializeComponent();
            int a = 9;

        }

        private void bt_out_text(object sender, RoutedEventArgs e)
        {
            
            Button bt = sender as Button;
            bt.Content = "туц туц туц";
            lb.Content = tb_1.Text;
        }
    }
}