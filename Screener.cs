using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoringPixelsFlood
{
    class Screener
    {
        private static ScreenCapture sc = new ScreenCapture();
        
        public static Image GetScreen()
        {
            return sc.CaptureScreen();
        }
    }
}
