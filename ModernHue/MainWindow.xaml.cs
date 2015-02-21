using System.Windows.Controls;
using CefSharp;
using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.IO;

namespace ModernHue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            
            if (!Cef.IsInitialized)
            {
                var settings = new CefSettings()
                { 
                };
                settings.CefCommandLineArgs.Add("disable-web-security", "1");
                
                Cef.Initialize(settings);
                
            }

        }

    }
}
