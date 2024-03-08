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
    /// BackgroundSetup.xaml 的交互逻辑
    /// </summary>
    public partial class BackgroundSetup : UserControl
    {
        public static readonly RoutedEvent SetBackgroundImageEvent = EventManager.RegisterRoutedEvent("SetBackgroundImage",
        RoutingStrategy.Bubble,typeof(RoutedEventHandler),typeof(BackgroundSetup));

        public event RoutedEventHandler SetBackgroundImage
        {
            add => AddHandler(SetBackgroundImageEvent, value);
            remove => RemoveHandler(SetBackgroundImageEvent, value);
        }


        public BackgroundSetup()
        {
            InitializeComponent();
            
        }

        private void test_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(sender.GetType().Name);
            Image bg = sender as Image;
            var args = new SetBackgroundImageEventArgs(bg);
            RaiseEvent(args);
        }
    }

    public class SetBackgroundImageEventArgs : RoutedEventArgs
    {
        public Image BackgroundImage { get; set; }

        public SetBackgroundImageEventArgs(Image image) : base(BackgroundSetup.SetBackgroundImageEvent)
        {
            this.BackgroundImage = image;
        }
    }
}
