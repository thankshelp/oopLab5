using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Forms
{
    class Galery : HoverButton
    {
        private string text = "";
        private Bitmap bitmap = new Bitmap(Properties.Resources._1);
        private int i = 1;

        public Galery() : base()
        {
            
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (i == 1)
                text = "Это доктор?";
            if (i == 2)
                text = "А это мужчина?";
            if (i == 3)
                text = "А это кто?";
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {

            pevent.Graphics.DrawImage(bitmap, 0, 0);

            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            pevent.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            text = "";
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            i++;

            if (i > 3)
                i = 1;

            if (i == 1)
            {
                bitmap = new Bitmap(Properties.Resources._1);
                text = "";
                text = "Это доктор?";
            }
            if (i == 2) 
            { 
            bitmap = new Bitmap(Properties.Resources._2);
            text = "";
            text = "А это мужчина?"; 
            }
            if (i == 3)
            {
                bitmap = new Bitmap(Properties.Resources._3);
                text = "";
                text = "А это кто?";
            }
        }
    }
}
