using System;
using System.Diagnostics;

namespace TinyTimer
{
    public class TinyTimer
    {
        public static double Benchmark(Action action, int samples = 10)
        {
            long ticks = 0;

            var sw = new Stopwatch();

            for (var i = 0; i < samples; i++)
            {
                sw.Start();
                action.Invoke();
                ticks += sw.ElapsedTicks;
                sw.Reset();
            }

            return ticks / (double)samples;
        }
    }
}