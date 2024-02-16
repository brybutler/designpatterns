namespace GangOf4Patterns.Events.Event.Args;
public class SpeedInfoEventArgs : EventArgs
{
    public int CurrentSpeed { get; set; }
    public bool IsSpeeding { get; set; }
}
