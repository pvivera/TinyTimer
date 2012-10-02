using System;

namespace TinyTimer.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TinyTimer.Benchmark(() =>
                {
                    var samples = new long[100000];
                    for (var i = 0; i < samples.Length; i++)
                    {
                        samples[i] = new Random().Next(10);
                    }
                }));

            Console.WriteLine(TinyTimer.Benchmark(() =>
                {
                    var result = 2 ^ 1000000;
                }, 10000));

            Console.Read();
        }
    }
}
