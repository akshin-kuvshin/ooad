class Event
{
    public readonly Key Key_;
    public readonly Point Point_;
    public readonly DateTime Time;
    public readonly bool Result;

    public Event(Key key, Point point, DateTime time, bool result, Area controllerArea)
    {
        Key_ = key;
        Point_ = point;
        Time = time;
        Result = result;

        if (Result)
            Key_.Owner.SwitchLocation(controllerArea);
    }
}
