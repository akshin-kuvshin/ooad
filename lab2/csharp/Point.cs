class Point
{
    private Controller controller;

    public Point(Controller controller)
    {
        this.controller = controller;
    }

    public void RequestAccess(Key key)
    {
        var accessAllowed = controller.CheckKey(key, this);
        if (accessAllowed)
            open();
        else // !accessAllower
            reject();
    }

    private void open() {}
    private void reject() {}
}
