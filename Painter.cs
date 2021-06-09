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

        private Form1 form1;

        public Painter(Form1 form)
        {
            form1 = form;
        }


        public static int mouseX = 0;
        public static int mouseY = 0;
        public static int minX = 0;
        public static int maxX = 0;
        public static int minY = 0;
        public static int maxY = 0;
        public static Bitmap bmp;

        public static int spaces = 18;
        public static int gridX = 105;
        public static int gridY = 51;
        public static int colours = 43;
        public static int minColors = 18;
        public static int n = minColors;


        public void paint()
        {
            Form1.getMouse(form1);
            int startX = (((int)((mouseX - minX) / spaces)) * spaces) + minX;
            int startY = (((int)((mouseY - minY) / spaces)) * spaces) + minY;
            Cursor.Position = new Point(startX, startY);
            
            /*while (!checkFull(mouseX, mouseY))
            { 
                click();
                if (mouseX + 36 > maxX)
                {
                    break;
                }
                else
                {
                    move(36, 0);
                    
                }
                
            }*/
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
                Form1.takeScreenShot(Form1.pics);
                if (bmp.GetPixel(1900, 920) == Color.FromArgb(255, 117, 118)) continue;
                Thread.Sleep(100);
                Form1.takeScreenShot(Form1.pics);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                bool fuller = false;
                for (int i = 0; i <= gridY; i++)
                {
                    for (int j = 0; j <= gridX; j++)
                    {

                        //if (!checkFull(mouseX, mouseY)) click();
                        if (checkFull(mouseX, mouseY))
                        {
                            fuller = false;
                        }
                        else
                        {
                            if (fuller)
                            {
                                Thread.Sleep(6);
                            }
                            else
                            {
                                Thread.Sleep(20);
                                fuller = true;
                            }
                        }

                        move(spaces, 0);
                        if (fuller)
                        {
                            if (checkFull(mouseX, mouseY))
                            {
                                Thread.Sleep(25);
                            }
                        }
                    }
                    if (fuller)
                        Thread.Sleep(30);
                    Cursor.Position = new Point(minX, mouseY);
                    move(0, spaces);
                    if (fuller)
                        Thread.Sleep(30);
                    if (!checkFull(mouseX, mouseY))
                    {
                        Thread.Sleep(30);
                    }
                    fuller = true;
                }
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(100);
                Form1.takeScreenShot(Form1.pics);
                Cursor.Position = new Point(minX, minY);
            }
            Thread.CurrentThread.Abort();
        }

       

        private bool checkFull(int posX, int posY)
        {
            Color someColor = bmp.GetPixel(posX, posY);
            for (int i = 0; i < 10; i++) //spaces*Math.Sqrt(spaces) - spaces*0.5
            {
                if (someColor.ToArgb() != bmp.GetPixel(posX + i, posY + i).ToArgb())
                    return false;
            }
            return true;
        }

        private void click()
        {
            Thread.Sleep(20);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(25);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(5);

        }

        private void move(int x, int y)
        {
            mouse_event(MOUSEEVENTF_MOVE, x, y, 0, 0);
            Form1.getMouse(form1);
        }
    }
}
