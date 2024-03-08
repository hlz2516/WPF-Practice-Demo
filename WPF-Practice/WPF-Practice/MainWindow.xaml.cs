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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<string> Menu { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //数据源
            //Menu = new List<string>();
            //Menu.Add("布局设置");
            //Menu.Add("背景切换");
            //准备binding
            //Binding binding = new Binding();
            //binding.Source = Menu;
            //binding.Path = new PropertyPath(".");
            ////使用binding连接源与目标
            //BindingOperations.SetBinding(this.tc, TabControl.ItemsSourceProperty, binding);
            //this.tc.DataContext = Menu;

            tc.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.ButtonClicked));
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine($"{(e.OriginalSource as FrameworkElement).Name}");
            string clickedName = (e.OriginalSource as FrameworkElement).Name;
            if (clickedName == "side_mode")
            {
                tc.TabStripPlacement = Dock.Left;
            }
            else if (clickedName == "top_mode")
            {
                tc.TabStripPlacement = Dock.Top;
            }
        }
    }
}
