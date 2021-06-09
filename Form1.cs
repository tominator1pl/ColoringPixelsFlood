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

        public static Label lab1;
        public static Label lab2;
        public static PictureBox pics;
        public static PictureBox pics2;
        Thread thread;

        public Form1()
        {
            InitializeComponent();
            lab1 = label1;
            lab2 = label2;
            pics2 = pictureBox2;
            pics = pictureBox1;
            
            HotKeyManager.RegisterHotKey(Keys.NumPad1, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.NumPad2, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.NumPad3, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.NumPad4, KeyModifiers.Alt);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);


        }

        public void MyThread()
        {
            Painter painter = new Painter(this);
            painter.paint();
        }

        public void UpdateMousePosition()
        {

        }

        private void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            if (e.Key == Keys.NumPad1)
            {
                takeScreenShot(Form1.pics);
                Painter.n = Painter.minColors;
                getMouse(this);
                Painter.minX = Painter.mouseX;
                Painter.minY = Painter.mouseY;
                Painter.maxX = Painter.mouseX + (Painter.spaces * Painter.gridX);
                Painter.maxY = Painter.mouseY + (Painter.spaces * Painter.gridY);
                thread = new Thread(new ThreadStart(MyThread));
                thread.Start();
            }
            if (e.Key == Keys.NumPad2)
            {
                thread.Abort();
            }
            if (e.Key == Keys.NumPad3)
            {
                Cursor.Position = new Point(Painter.minX, Painter.minY);
                Thread.Sleep(100);
                thread = new Thread(new ThreadStart(MyThread));
                thread.Start();
            }
            if (e.Key == Keys.NumPad4)
            {
                thread.Abort();
                Painter.n = Painter.n + 1;
                Thread.Sleep(100);
                Cursor.Position = new Point(Painter.minX, Painter.minY);
                Thread.Sleep(100);
                thread = new Thread(new ThreadStart(MyThread));
                thread.Start();
            }

        }

        public static void getMouse(Form form)
        {
            form.Invoke(new EventHandler(delegate {
                lab1.Text = MousePosition.X + " " + MousePosition.Y;
                Color clr = Painter.bmp.GetPixel(MousePosition.X, MousePosition.Y);
                lab2.Text = clr.R + "," + clr.G + "," + clr.B;
                Bitmap col = new Bitmap(100, 100);
                Graphics g = Graphics.FromImage(col);
                g.Clear(Color.FromArgb(clr.R, clr.G, clr.B));
                pics2.Image = col;
            }));
            

            Painter.mouseX = MousePosition.X;
            Painter.mouseY = MousePosition.Y;
        }

        public static void takeScreenShot(PictureBox pic)
        {

            Image img = Screener.getScreen();
            Painter.bmp = new Bitmap(img);
            pic.Invoke(new EventHandler(delegate
            {
                pic.Image = img;
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
    }
}
