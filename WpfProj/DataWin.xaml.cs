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
using System.Windows.Shapes;

namespace WpfProj
{
    /// <summary>
    /// DataWin.xaml 的交互逻辑
    /// </summary>
    public partial class DataWin : Window
    {
        public DataWin()
        {
            InitializeComponent();

            List<Color> ints = new List<Color>();

            ints.Add(new Color() { Code = "#FFDAB9", Name = "PeachPuff" });
            ints.Add(new Color() { Code = "#E6E6FA", Name = "lavender" });
            ints.Add(new Color() { Code = "#7B68EE", Name = "MediumSlateBlue" });
            ints.Add(new Color() { Code = "#CD5C5C", Name = "IndianRed" });

            DataList.ItemsSource = ints;

            dataGrid.ItemsSource = ints;
        }
    }

    public class Color
    {
        public string Code {  get; set; }
        public string Name { get; set; }
    }
}
