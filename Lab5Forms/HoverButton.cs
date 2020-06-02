using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Forms
{
    class HoverButton : Button
    {
        protected Color color = Color.Blue;

        protected StringFormat stringFormat;

        public HoverButton() : base()
        {
            ForeColor = Color.Blue;

            Font = new Font("Microsoft YaHei UI",
             20.25F,
             FontStyle.Bold,
             GraphicsUnit.Point,
             0);
        }
    }
}
