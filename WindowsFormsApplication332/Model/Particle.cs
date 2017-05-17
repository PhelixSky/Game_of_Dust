using System;
using System.Drawing;

namespace Game_of_Dust.Model
{
    /// <summary>
    /// Базовый класс частицы
    /// </summary>
    abstract class Particle
    {
        public PointF Location { get; set; }
        //public PointF PrevLocation { get; set; }
        public PointF Velocity { get; set; }
        public PointF Acceleration { get; set; }
        //public PointF Force { get; set; }
        public float Mass { get; set; }
        public virtual Color Color { get; set; }
        //public float AirFriction { get; set; }

        public int X { get { return (int)Location.X; } }
        public int Y { get { return (int)Location.Y; } }

        public Particle()
        {
            Mass = 1;
            Color = Color.Orange;
            //сила тяжести
            Acceleration = new PointF(0, 9.8f);
        }

        /// <summary>
        /// Обновление сил, скоростей и координат
        /// </summary>
        public virtual void Update(Sandbox sb, float dt)
        {
            var PrevLocation = Location;

            //приращение скорости
            Velocity = Velocity.Add(Acceleration, dt*dt);
            //приращение координаты
            Location = Location.Add(Velocity);
            //мы ударились о другую частицу?
            var cell = sb[X,Y];
            if (cell != null && cell != this)
            {
                //остаемся на месте, обрабатываем столкновение
                Location = PrevLocation;
                OnCollision(sb, cell);
            }
           

        }

        /// <summary>
        /// Событие соударения
        /// </summary>
        public virtual void OnCollision(Sandbox sb, Particle other)
        {
           if (other.Mass < Mass)//меняем местами, если столкнулись с более тяжелой частицей
            {
                var loc = other.Location;
                other.Location = Location;
                Location = loc;
            }
            else
              Velocity = new PointF(FastRnd.Next(), 0);
        }
        
    }
}
