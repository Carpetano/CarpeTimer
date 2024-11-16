using System;
using System.Diagnostics;
using System.Windows.Forms;

public class TimerControl
{

    public Stopwatch Stopwatch { get; private set; } = new Stopwatch();
    public Timer Timer { get; private set; } = new Timer();
    public event Action<string, string, string> OnTimeUpdated;

    public TimerControl()
    {
        Timer.Interval = 1000; // Tick every second
        Timer.Tick += Timer_Tick;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        TimeSpan span = new TimeSpan(0, 0, 0, 0, (int)Stopwatch.ElapsedMilliseconds);

        string hours = span.Hours.ToString("D2");
        string minutes = span.Minutes.ToString("D2");
        string seconds = span.Seconds.ToString("D2");

        OnTimeUpdated?.Invoke(hours, minutes, seconds);
    }

    public void Start()
    {
        Stopwatch.Start();
        Timer.Start();
    }

    public void Stop()
    {
        Stopwatch.Stop();
        Timer.Stop();
    }

    public void Reset()
    {
        Stopwatch.Reset();
        Timer.Stop();
    }

}
