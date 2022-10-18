using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ColoringPixelsFlood
{
    public class Guide
    {
        private Thread thread;
        private static Form1 form;
        private Point oldMousePos;
        private SizeF cellSize;
        private Point curMousePos;
        public bool second = true;

        public Guide(Form1 form)
        {
            Guide.form = form;
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
        
        public void UpdatePainter()
        {
            Painter.spaces = cellSize.Width;
            Painter.maxX = curMousePos.X;
            Painter.maxY = curMousePos.Y;
            Painter.minX = oldMousePos.X;
            Painter.minY = oldMousePos.Y;
        }

        private void ThreadStart()
        {
            oldMousePos = form.GetMouse();
            Pen pen = new Pen(Color.LimeGreen, 1f);
            Image clearImage = (Image)form.pics.Image.Clone();
            while (true)
            {
                if(second) curMousePos = form.GetMouse();
                SizeF mouseDiff = new SizeF(curMousePos.X - oldMousePos.X, curMousePos.Y - oldMousePos.Y);
                cellSize = new SizeF(mouseDiff.Width / Painter.gridX, mouseDiff.Height / Painter.gridY);
                Rectangle rect = new Rectangle(oldMousePos, mouseDiff.ToSize());
                Bitmap bitmap = new Bitmap(clearImage);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.DrawRectangle(pen, rect);
                    for(int i = 0; i < Painter.gridX; i++)
                    {
                        g.DrawLine(pen, oldMousePos.X + i * cellSize.Width, oldMousePos.Y, oldMousePos.X + i * cellSize.Width, curMousePos.Y);
                    }
                    for (int i = 0; i < Painter.gridY; i++)
                    {
                        g.DrawLine(pen, oldMousePos.X, oldMousePos.Y + i * cellSize.Height, curMousePos.X, oldMousePos.Y + i * cellSize.Height);
                    }
                }
                Form1.InvokeImage(bitmap);
                Thread.Sleep(10);
            }
        }

    }
}
