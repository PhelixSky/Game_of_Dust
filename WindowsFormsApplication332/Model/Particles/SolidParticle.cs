using System.Drawing;

namespace Game_of_Dust.Model.Particles
{
    class SolidParticle : Particle
    {
        public SolidParticle()
        {
            Color = Color.Gray;
            Mass = 100;
        }

        public override void Update(Sandbox sb, float dt)
        {
            //мы неподвижны
        }
    }
}
