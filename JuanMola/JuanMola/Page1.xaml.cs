using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JuanMola
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private Frame _frame;
        public Page1(Frame frame)
        {
            InitializeComponent();
            this._frame = frame;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            _frame.Navigate(new Page2(_frame));
        }
    }
}
