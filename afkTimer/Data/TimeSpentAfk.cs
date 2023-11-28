using System;
using System.Diagnostics;

namespace afkTimer.data;

public class StateStopwatch
{
    private readonly Stopwatch stopwatch;

    public StateStopwatch()
    {
        stopwatch = new Stopwatch();
    }

    public void Start()
    {
        stopwatch.Start();
    }

    public void Stop()
    {
        stopwatch.Stop();
    }

    public void Reset()
    {
        stopwatch.Reset();
    }

    public TimeSpan ElapsedTime
    {
        get { return stopwatch.Elapsed; }
    }
}
