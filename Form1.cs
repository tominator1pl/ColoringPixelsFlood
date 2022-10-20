using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace ColoringPixelsFlood
{
    public partial class Form1 : Form
    {

        public Label lab1;
        public PictureBox pics;
        public static PictureBox stPic;
        public static Label stGuideLabel;
        public static bool bTurboCheckBox;
        public static bool bIgnoreCheckBox;
        public bool afterGuide;
        private int guideStep;
        Thread thread;
        Painter painter;
        Guide guide;
        Finder finder;

        public Form1()
        {
            InitializeComponent();
            lab1 = guideLabel;
            stGuideLabel = guideLabel;
            bTurboCheckBox = false;
            bIgnoreCheckBox = false;
            pics = pictureBox1;
            stPic = pictureBox1;
            painter = new Painter(this);
            guideStep = 0;
            afterGuide = false;

            HotKeyManager.RegisterHotKey(Keys.NumPad1, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.NumPad2, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.NumPad3, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.NumPad4, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.NumPad5, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.NumPad6, KeyModifiers.Alt);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);


        }

        private void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            switch (e.Key)
            {
                case Keys.NumPad1:
                    if (!afterGuide) return;
                    TakeScreenShot();
                    Painter.n = Painter.minColors;
                    //GetMouse();
                    /*Painter.minX = MousePosition.X;
                    Painter.minY = MousePosition.Y;
                    Painter.maxX = MousePosition.X + (Painter.spaces * Painter.gridX);
                    Painter.maxY = MousePosition.Y + (Painter.spaces * Painter.gridY);*/
                    thread = new Thread(new ThreadStart(painter.Paint));
                    thread.Start();
                    break;

                case Keys.NumPad2:
                    thread.Abort();
                    break;
                    
                case Keys.NumPad3:
                    Cursor.Position = new Point((int)Painter.minX, (int)Painter.minY);
                    Thread.Sleep(100);
                    thread = new Thread(new ThreadStart(painter.Paint));
                    thread.Start();
                    break;

                case Keys.NumPad4:
                    thread.Abort();
                    Painter.n = Painter.n + 1;
                    Thread.Sleep(100);
                    Cursor.Position = new Point((int)Painter.minX, (int)Painter.minY);
                    Thread.Sleep(100);
                    thread = new Thread(new ThreadStart(painter.Paint));
                    thread.Start();
                    break;

                case Keys.NumPad5:
                    StartGuide();
                    break;

                case Keys.NumPad6:
                    InvokeGuideLabel("Detecting the Image...");
                    StartFinder();
                    break;
            }

        }

        private void StartGuide()
        {
            switch (guideStep)
            {
                case 0:
                    TakeScreenShot();
                    afterGuide = false;
                    InvokeGuideLabel("Move your mouse to top left corner of the picture to select first corner.\nPress Alt + Numpad5 when ready.");
                    break;
                case 1:
                    guide = new Guide(this);
                    guide.Start();
                    InvokeGuideLabel("Move your mouse to bottom right corner of the picture to select second corner. You should see a helper rectangle on the right.\nPress Alt + Numpad5 when ready.");
                    break;
                case 2:
                    guide.second = false;
                    InvokeGuideLabel("Adjust grid size. You should see a helper rectangle on the right.\nPress Alt + Numpad5 when ready.");
                    break;
                case 3:
                    guide.UpdatePainter();
                    afterGuide = true;
                    guide.Abort();
                    InvokeGuideLabel("Now you can press Alt + Numpad1 to start.");
                    guideStep = -1;
                    break;
            }
            guideStep++;
        }

        private void StartFinder()
        {
            TakeScreenShot();
            finder = new Finder(this);
            finder.Start();
        }

        public void GuideFromFinder(Point topLeft, Point bottomRight)
        {
            afterGuide = false;
            guide = new Guide(this, topLeft, bottomRight);
            guide.Start();
            guideStep = 2;
            StartGuide();
            finder.Abort();
        }

        public Point GetMouse()
        {
            return new Point(MousePosition.X, MousePosition.Y);
        }
        
        public void TakeScreenShot()
        {
            if(Painter.bmp != null) Painter.bmp.Dispose();
            Image img = Screener.GetScreen();
            Painter.bmp = new Bitmap(img);
            InvokeImage(img);
        }

        public static void InvokeImage(Image image)
        {
            stPic.Invoke(new EventHandler(delegate
            {
                if (stPic.Image != null) stPic.Image.Dispose();
                stPic.Image = image;
            }));
        }

        public static void InvokeGuideLabel(string text)
        {
            stGuideLabel.Invoke(new EventHandler(delegate
            {
                stGuideLabel.Text = text;
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericX_ValueChanged(object sender, EventArgs e)
        {
            Painter.gridX = (int)numericX.Value;
        }

        private void numericY_ValueChanged(object sender, EventArgs e)
        {
            Painter.gridY = (int)numericY.Value;
        }

        private void numericColors_ValueChanged(object sender, EventArgs e)
        {
            Painter.colours = (int)numericColors.Value;
        }

        private void numericMinColors_ValueChanged(object sender, EventArgs e)
        {
            Painter.minColors = (int)numericMinColors.Value;
            Painter.n = Painter.minColors;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null) thread.Abort();
            if (thread != null) guide.Abort();
        }

        private void turboCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bTurboCheckBox = turboCheckBox.Checked;
        }

        private void ignoreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bIgnoreCheckBox = ignoreCheckBox.Checked;
        }
    }
}
