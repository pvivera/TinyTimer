using System;
using System.Linq;

namespace TinyTimer
{
    public class TinyTimer
    {
        public static double Benchmark(Action action, int samples = 10)
        {
            var times = new TimeSpan[samples];

            for (var i = 0; i < samples; i++)
            {
                var start = DateTime.Now;
                action.Invoke();
                times[i] = DateTime.Now - start;
            }

            return TimeSpan.FromTicks(times.Select(t=>t.Ticks).Sum() / samples).TotalMilliseconds;
        }
    }
}
