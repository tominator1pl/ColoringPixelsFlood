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
        private Image clearImage;
        public bool second = true;

        public Guide(Form1 form)
        {
            Guide.form = form;
            thread = new Thread(new ThreadStart(ThreadStart));
        }

        public Guide(Form1 form, Point firstPos, Point secondPos)
        {
            Guide.form = form;
            oldMousePos = firstPos;
            curMousePos = secondPos;
            second = false;
            thread = new Thread(new ThreadStart(ThreadStart));
        }

        public void Start()
        {
            thread.Start();
        }

        public void Abort()
        {
            thread.Abort();
            clearImage.Dispose();
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
            if(second) oldMousePos = form.GetMouse();
            Pen pen = new Pen(Color.LimeGreen, 1f);
            clearImage = (Image)form.pics.Image.Clone();
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
                        PointF first = new PointF(oldMousePos.X + i * cellSize.Width, oldMousePos.Y);
                        PointF second = new PointF(oldMousePos.X + i * cellSize.Width, curMousePos.Y);
                        if(first != second)
                            g.DrawLine(pen, first, second);
                    }
                    for (int i = 0; i < Painter.gridY; i++)
                    {
                        PointF first = new PointF(oldMousePos.X, oldMousePos.Y + i * cellSize.Height);
                        PointF second = new PointF(curMousePos.X, oldMousePos.Y + i * cellSize.Height);
                        if (first != second)
                            g.DrawLine(pen, first, second);
                    }
                }
                Form1.InvokeImage(bitmap);
                Thread.Sleep(20);
                
            }
        }

    }
}
