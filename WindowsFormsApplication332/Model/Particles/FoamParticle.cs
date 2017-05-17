using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Game_of_Dust.Model.Particles
{
    class FoamParticle : Particle
    {
        public FoamParticle()
        {
            Mass = 0.1f;
            var orange = Color.LightGoldenrodYellow;
            var d = (int)(Math.Abs(FastRnd.Next()) * 100);
            Color = Color.FromArgb(orange.R - d, orange.G - d, orange.B);
            //
            Velocity = new PointF(FastRnd.Next() * 2, FastRnd.Next() * 2);
        }
    }
}
