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

namespace WPF_Practice
{
    /// <summary>
    /// ImageBox.xaml 的交互逻辑
    /// </summary>
    public partial class ImageBox : UserControl
    {
        public ImageBox()
        {
            InitializeComponent();
            this.Name = "image" + Guid.NewGuid().ToString().Substring(0,8);
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RaiseEvent(e);
        }
    }
}
