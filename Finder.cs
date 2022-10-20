using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ColoringPixelsFlood
{
    public class Finder
    {
        private Form1 form;
        private Thread thread;
        public Finder(Form1 form1)
        {
            form = form1;
            thread = new Thread(new ThreadStart(ThreadStart));
        }

        public void Start()
        {
            thread.Start();
        }

        public void Abort()
        {
            thread.Abort();
        }

        private void ThreadStart()
        {
            Image imm = (Image)form.pics.Image.Clone();
            Bitmap image = new Bitmap(imm);
            imm.Dispose();
            int height = image.Height;
            int width = image.Width;
            Color backgroundColor = image.GetPixel(0, 0);
            int foundBlackPixelY = 0;
            for(int y = 0; y < height; y++) //Step one: Find bottom menu to restrict search size
            {
                Color pixel = image.GetPixel(0, y);
                if (pixel != backgroundColor)
                {
                    foundBlackPixelY = y;
                    break;
                }
            }
            int workingHeight = foundBlackPixelY-1;
            int minX = 0, minY = 0, maxX = 0, maxY = 0;
            for(int x = 0; x < width; x++) //search minX
            {
                for(int y = 0; y< workingHeight; y++)
                {
                    Color pixel = image.GetPixel(x, y);
                    if (pixel != backgroundColor)
                    {
                        minX = x;
                        break;
                    }
                }
            }
            for (int y = 0; y < workingHeight; y++) //search minY
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    if (pixel != backgroundColor)
                    {
                        minY = y;
                        break;
                    }
                }
            }
            for (int x = width-1; x > 0; x--) //search maxX
            {
                for (int y = 0; y < workingHeight; y++)
                {
                    Color pixel = image.GetPixel(x, y);
                    if (pixel != backgroundColor)
                    {
                        maxX = x;
                        break;
                    }
                }
            }
            for (int y = workingHeight; y > 0; y--) //search maxY
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    if (pixel != backgroundColor)
                    {
                        maxY = y;
                        break;
                    }
                }
            }
            image.Dispose();
            Point topLeft = new Point(maxX, maxY);
            Point bottomRight = new Point(minX, minY);
            form.GuideFromFinder(topLeft, bottomRight);
        }
    }
}
