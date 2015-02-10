using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernHue.NativeBridge
{
    public class NativeAppBridge
    {
        public bool HandleUrl(string url)
        {
            System.Diagnostics.Process.Start(url);
            return false;
        }

        public string CoverArt 
        {
            get { return "todo"; }
        }
    }
}
