using System;
using System.IO;
using System.Windows.Controls;
using CefSharp;
using ModernHue.NativeBridge;

namespace ModernHue.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            string urlToNavigate = new Uri(String.Format("file:///{0}/html/index.html", curDir)).ToString();

            Browser.RegisterJsObject("winapp", new NativeAppBridge());
            Browser.Address = urlToNavigate;
        }
    }
}
