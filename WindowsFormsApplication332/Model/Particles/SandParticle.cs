using System;
using System.Drawing;

namespace Game_of_Dust.Model.Particles
{

    class SandParticle : Particle
    {
        public SandParticle()
        {
            var orange = Color.Orange;
            //делаем вариацию цвета
            var d = (int)(Math.Abs(FastRnd.Next()) * 100);
            Color = Color.FromArgb(orange.R - d, orange.G - d, orange.B);
            //
            Velocity = new PointF(FastRnd.Next() * 2, FastRnd.Next() * 2);
        }
    }
}
