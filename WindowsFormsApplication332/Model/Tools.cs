using System;
using System.Drawing;
using Game_of_Dust.Model.Particles;

namespace Game_of_Dust.Model
{
    /// <summary>
    /// Создает частицы
    /// </summary>
    class Tools
    {
        public Sandbox Sandbox { get; set; }

     
        public void CreateParticles<T>(Point p, int radius) where T : Particle, new()
        {
            lock (Sandbox.Particles)
                for (int x = p.X - radius; x <= p.X + radius; x++)
                    for (int y = p.Y - radius; y <= p.Y + radius; y++)
                    {
                        if (Sandbox[x, y] == null)//если ячейка не занята, создаем частицу
                        {
                            var particle = new T() { Location = new PointF(x + 0.5f, y + 0.5f) };
                            Sandbox.Particles.AddLast(particle);
                        }
                    }
        }

    }
}
