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

namespace ColoringPixelsFlood
{
    class Painter
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        
        public const int MOUSEEVENTF_MOVE = 0x01;
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        private int turboSpeed = 100000; //speed is after each square
        private int turboSlowdown = 500000; //slowdown is after break eg. skipping full squares, new line etc.
        private int slowSpeed = 6; //turbo is used when checked without VSync (super fast)
        private int slowSlowdown = 25; //slow is with VSync

        private static Form1 form1;
        public static float minX = 0;
        public static float maxX = 0;
        public static float minY = 0;
        public static float maxY = 0;
        public static Bitmap bmp;

        public static float spaces = 15;
        public static int gridX = 1;
        public static int gridY = 1;
        public static int colours = 99;
        public static int minColors = 1;
        public static int n;

        public static PointF mousePrivate;
        public Painter(Form1 form)
        {
            form1 = form;
            n = minColors;
            mousePrivate = form.GetMouse();
        }

        public void Paint()
        {
            //Point mousePos = form1.GetMouse();
            float startX = minX + spaces / 2;
            float startY = minY + spaces / 2;
            mousePrivate = new PointF(startX, startY);
            Cursor.Position = new Point((int)mousePrivate.X, (int)mousePrivate.Y);
            for (; n <= colours; n++)
            {


                if (n < 10)
                {
                    SendKeys.SendWait("0");
                    Thread.Sleep(100);
                    SendKeys.SendWait(n.ToString());
                }
                else
                {
                    SendKeys.SendWait(((int)(n / 10)).ToString());
                    Thread.Sleep(100);
                    SendKeys.SendWait((n % 10).ToString());
                }
                Thread.Sleep(100);
                form1.TakeScreenShot();
                if (bmp.GetPixel(1900, 920) == Color.FromArgb(255, 117, 118)) continue; 
                //Thread.Sleep(200);
                form1.TakeScreenShot();
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                bool fuller = false;
                for (int i = 0; i <= gridY; i++)
                {
                    for (int j = 0; j <= gridX; j++)
                    {
                        //mousePos = form1.GetMouse();
                        if (CheckFull(mousePrivate.X, mousePrivate.Y))
                        {
                            fuller = false;
                        }
                        else
                        {
                            if (fuller)
                            {
                                Sleep(false);
                            }
                            else
                            {
                                Sleep(true);
                                fuller = true;
                            }
                        }

                        //Move(spaces, 0);
                        mousePrivate = new PointF(mousePrivate.X + spaces, mousePrivate.Y);
                        Cursor.Position = new Point((int)mousePrivate.X, (int)mousePrivate.Y);
                        if (fuller)
                        {
                            //mousePos = form1.GetMouse();
                            if (CheckFull(mousePrivate.X, mousePrivate.Y))
                            {
                                Sleep(true);
                            }
                        }
                    }
                    if (fuller)
                        Sleep(true);
                    //mousePos = form1.GetMouse();
                    mousePrivate = new PointF(startX, mousePrivate.Y);
                    Cursor.Position = new Point((int)mousePrivate.X, (int)mousePrivate.Y);
                    //Move(0, spaces);
                    mousePrivate = new PointF(mousePrivate.X, mousePrivate.Y + spaces);
                    Cursor.Position = new Point((int)mousePrivate.X, (int)mousePrivate.Y);
                    if (fuller)
                        Sleep(true);
                    //mousePos = form1.GetMouse();
                    if (!CheckFull(mousePrivate.X, mousePrivate.Y))
                    {
                        Sleep(true);
                    }
                    fuller = true;
                }
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                //Thread.Sleep(100);
                //form1.TakeScreenShot();
                mousePrivate = new PointF(startX, startY);
                Cursor.Position = new Point((int)mousePrivate.X, (int)mousePrivate.Y);
            }
            Thread.CurrentThread.Abort();
        }

       
        
        private bool CheckFull(float posX, float posY)
        {
            posX = (posX - spaces / 2) + 1;
            posY = (posY - spaces / 2) + 1;
            float diag = spaces - 2;
            float endX = posX + diag;
            float endY = posY + diag;
            Color someColor = bmp.GetPixel((int)posX, (int)posY);
            for (float x = posX; x < endX; x++)
            {
                for(float y = posY; y < endY; y++)
                {
                    try
                    {
                        if (someColor.ToArgb() != bmp.GetPixel((int)x, (int)y).ToArgb())
                            return false;
                    }
                    catch (Exception)
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Sleep for some time
        /// </summary>
        /// <param name="slow">if its the one after a break</param>
        private void Sleep(bool slow)
        {
            int turboTicks;
            int slowTicks;
            if (slow)
            {
                turboTicks = turboSlowdown;
                slowTicks = slowSlowdown;
            }
            else
            {
                turboTicks = turboSpeed;
                slowTicks = slowSpeed;
            }

            if (Form1.stTurboCheckBox.Checked)
            {
                Thread.SpinWait(turboTicks);
            }
            else
            {
                Thread.Sleep(slowTicks);
            }
        }
    }
}
