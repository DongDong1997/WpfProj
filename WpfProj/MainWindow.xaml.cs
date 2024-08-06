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

namespace WpfProj
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ArrangeWin arrangeWin = new ArrangeWin();
            arrangeWin.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StyleWin styleWin = new StyleWin();
            styleWin.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ControlWin controlWin = new ControlWin();
            controlWin.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DataWin dataWin = new DataWin();
            dataWin.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            BindingWin bindingWin = new BindingWin();
            bindingWin.Show();
        }
    }
}
