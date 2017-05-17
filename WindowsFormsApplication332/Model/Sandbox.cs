using System;
using System.Drawing;
using System.Text;
using System.Collections.Generic;

namespace Game_of_Dust.Model
{
    /// <summary>
    /// Песочница - контейнер частиц
    /// </summary>
    class Sandbox
    {
        public const int WIDTH = 600;
        public const int HEIGHT = 432;

        public LinkedList<Particle> Particles = new LinkedList<Particle>();
        public Particle[,] Cells = new Particle[WIDTH, HEIGHT];

        public Particle this[int x, int y]
        {
            get
            {
                if (x < 0 || x >= WIDTH || y < 0 || y >= HEIGHT) return null;
                return Cells[x, y];
            }
            set {}
        }

        public void Update(float dt)
        {
            //обновляем частицы
            var pp = Particles.First;
            while (pp != null)
            {
                var next = pp.Next;
                pp.Value.Update(this, dt);
                pp = next;
            }

            //заносим частицы в новые ячейки
            var newCells = new Particle[WIDTH, HEIGHT];
            pp = Particles.First;
            while(pp != null)
            {
                var next = pp.Next;
                var p = pp.Value;
                var xx = (int)p.Location.X;
                var yy = (int)p.Location.Y;
                //частица вышла за пределы поля?
                if (xx < 0 || xx >= WIDTH || yy < 0 || yy >= HEIGHT)
                    lock (Particles) Particles.Remove(pp);//удаляем
                else
                    newCells[xx, yy] = p;
                pp = next;
            }

            Cells = newCells;
            
        }
    }
}
