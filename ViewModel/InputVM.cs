using _2307cb1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace _2307cb1.ViewModel
{
    internal class InputVM
    {
        private RelayCommand bt_out_text;
        public RelayCommand Bt_out_text
        {
            get
            {
                return bt_out_text ??
                  (bt_out_text = new RelayCommand(obj =>
                  {
                      Button button = obj as Button;

                      button.MouseEnter += Bt_1_MouseEnter;
                      MessageBox.Show("tyt");
                  }));
            }
        }
        private void Bt_1_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MessageBox.Show("Mouse enter");
        }
    }
}
