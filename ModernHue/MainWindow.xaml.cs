using System.Windows.Controls;
using CefSharp;
using FirstFloor.ModernUI.Windows.Controls;

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
                Cef.Initialize();
                /*
                    new CefSettings()
                { 
                FileAccessFromFileUrlsAllowed = true,
                UniversalAccessFromFileUrlsAllowed = true,
                TextAreaResizeDisabled = true,
                    
                });*/
            }

        }


    }
}
