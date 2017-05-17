using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game_of_Dust.Model
{
    public static class FastRnd
    {
        const int COUNT = 0xFFFF;
        static float[] rnds = new float[COUNT + 1];
        private static int counter = 0;

        public static float Next()
        {
            counter = (counter + 1) & COUNT;
            return rnds[counter];
        }

        static FastRnd()
        {
            var rnd = new Random();
            for (int i = 0; i < COUNT; i++)
                rnds[i] = (float)(rnd.NextDouble() * 2 - 1);
        }
    }
}

