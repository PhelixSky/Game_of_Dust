using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Game_of_Dust.Model;

namespace Game_of_Dust
{
    /// <summary>
    /// Панель отрисовки модели
    /// </summary>
    partial class SandboxPanel : UserControl
    {
        private Bitmap bmp;
        public Sandbox Sandbox { get; set; }

        public SandboxPanel()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            //создаем буферный битмап
            bmp = new Bitmap(Sandbox.WIDTH, Sandbox.HEIGHT, PixelFormat.Format32bppPArgb);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //игнорируем отрисовку бекграунда
        }
        public int FrameCounter { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Sandbox == null)
                return;
            FrameCounter++;

            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            //отрисовываем частицы на битмапе
            var particles = Sandbox.Cells;

            using(var wr = new ImageWrapper(bmp, false))
            for (int x = 0; x < Sandbox.WIDTH; x++)
            for (int y = 0; y < Sandbox.HEIGHT; y++)
            {
                var p = particles[x, y];
                if (p != null)
                {
                    var c = p.Color;
                    wr.SetPixelUnsafe(x, y, c.R, c.G, c.B);
                }
            }

            //отрисовываем битмап
            e.Graphics.DrawImageUnscaled(bmp, Point.Empty);
        }

        private void SandboxPanel_Load(object sender, EventArgs e)
        {

        }

    }
}
