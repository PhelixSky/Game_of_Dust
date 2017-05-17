using System;
using System.Drawing;

namespace Game_of_Dust.Model.Particles
{
    class WaterParticle : Particle
    {
        public override Color Color
        {
            get
            {
                //анимация цвета
                var s = 20 + (int)(Math.Sin(Location.Y / 2f + DateTime.Now.Millisecond / 150f) * 10);
                return Color.FromArgb(0, s * 2, 255);
            }
        }

        public WaterParticle()
        {
            Mass = 0.5f;
            Velocity = new PointF(FastRnd.Next() * 2, FastRnd.Next() * 2);
        }

        public override void OnCollision(Sandbox sb, Particle other)
        {
            if (other.Mass < Mass)//меняем местами, если столкнулись с более тяжелой частицей
            {
                var loc = other.Location;
                other.Location = Location;
                Location = loc;
            }
            Velocity = Velocity.Mult(-0);
            Velocity = Velocity.Add(new PointF(FastRnd.Next() * 2, FastRnd.Next() * 1f));
        }
    }
}
