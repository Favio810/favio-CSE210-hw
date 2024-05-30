using System;
using System.Collections.Generic;

public class BreathingActivity: Activity
{
    private int _durationBreathing;

    public void BreathingExcercise()
    {
        List<string> breathingLoop = new List<string>();
        breathingLoop.Add("Breath in...");
        breathingLoop.Add("Now breath out...");

        Activity actBreathing = new Activity();

        foreach (string v in breathingLoop)
        {
            Console.WriteLine("");
            Console.Write(v);
            actBreathing.ShowCountDown(5);
            Console.Write("\b \b");
        }
    }
    public void Run(int durationBreathing)
    {
        _durationBreathing = durationBreathing;
        DateTime startTime = DateTime.Now;
        DateTime durationTime = startTime.AddSeconds(durationBreathing);
        
        DateTime currentTime = DateTime.Now;
        while (DateTime.Now < durationTime)
        {
            BreathingExcercise();
        }
        Console.WriteLine("End");
    }
}