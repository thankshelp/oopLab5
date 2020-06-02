using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Forms
{
    class GaleryCircle : Galery
    {
        private Bitmap bitmap;

        public GaleryCircle() : base() 
        {
            this.bitmap = new Bitmap(Properties.Resources._1);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
            Region = new Region(graphicsPath);
        }

    }
}
