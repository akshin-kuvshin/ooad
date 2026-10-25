class Point
{
    private Controller controller;
    public readonly bool Entry;

    public Point(Controller controller, bool entry)
    {
        this.controller = controller;
        Entry = entry;
    }

    public void RequestAccess(Key key)
    {
        var accessAllowed = controller.CheckKey(key, this);
        if (accessAllowed)
            open();
        else // !accessAllowed
            reject();
    }

    private void open() {}
    private void reject() {}
}
