TinyTimer
=========

Runs an action and returns the timing in milliseconds.

#### Usage

    Console.WriteLine(TinyTimer.Benchmark(() =>
    {
      var samples = new long[100000];
      for (var i = 0; i < samples.Length; i++)
      {
        samples[i] = new Random().Next(10);
      }
    }, 100));