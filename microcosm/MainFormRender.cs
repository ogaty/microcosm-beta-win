using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace microcosm
{
    partial class MainForm
    {
        public Bitmap canvas;
        public Bitmap canvas2;
        public void singleChartRender(int center_value = 0)
        {
            if (center_value == 0)
            {
                center_value = Common.chart_center_radius;
            }
            canvas = new Bitmap(500, 450);
            canvas2 = new Bitmap(400, 350);
            // 外側
            circleRender(canvas, Pens.Black, Common.chart_padding, Common.chart_radius * 2);

            // 内側
            circleRender(canvas, Pens.Black, Common.chart_padding + Common.chart_radius - Common.chart_ring_radius, Common.chart_ring_radius * 2);

            // 中央
            circleRender(canvas, Pens.Black, Common.chart_radius - center_value + Common.chart_padding, center_value * 2);

            astroWindow.Image = canvas;



        }

        private void circleRender(Bitmap canvas, Pen pen, int pos, int size)
        {
            Graphics g = Graphics.FromImage(canvas);
            g.DrawEllipse(pen, pos, pos, size, size);
            g.Dispose();
        }
    }
}
