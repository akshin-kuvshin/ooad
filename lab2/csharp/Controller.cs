class Controller
{
    private Area area;
    private Journal journal = new();

    public Controller(Area area)
    {
        this.area = area;
    }

    public bool CheckKey(Key key, Point point)
    {
        var time = DateTime.Now;
        var keyLocation = key.GetLocation();

        var accessAllowed = false;
        if (keyLocation is not null && area.Equals(keyLocation))
        {
            var rules = key.GetRules();
            accessAllowed = checkRules(rules, time);
        }

        journal.EmplaceEvent(key, point, time, accessAllowed, area);
        return accessAllowed;
    }

    private bool checkRules(IReadOnlyList<Rule> rules, DateTime time)
    {
        var dayOfWeek = ((int)time.DayOfWeek + 6) % 7;
        var timeOnly = TimeOnly.FromDateTime(time);

        foreach (var rule in rules)
        {
            var accessAllowed = rule.Allows(area, dayOfWeek, timeOnly);
            if (accessAllowed)
                return true;
        }
        return false;
    }
}
