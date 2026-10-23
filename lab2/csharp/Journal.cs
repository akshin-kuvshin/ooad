class Journal
{
    private List<Event> events = new();

    public IReadOnlyList<Event> GetEvents() => events.AsReadOnly();

    public void EmplaceEvent(Key key, Point point, DateTime time, bool result, Area controllerArea)
    {
        Event event_ = new(key, point, time, result, controllerArea);
        events.Add(event_);
    }
}
