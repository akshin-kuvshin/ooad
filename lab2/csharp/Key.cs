abstract class Key
{
    public Staff Owner { get; set; }
    private List<Rule> rules = new();
    private Area? location;

    public Key(Staff owner)
    {
        Owner = owner;
    }

    public IReadOnlyList<Rule> GetRules() => rules.AsReadOnly();

    public void EmplaceRule(Area ruleArea, List<TimeOnly?> accessTimeStart, List<TimeOnly?> accessTimeEnd)
    {
        Rule rule = new(ruleArea, accessTimeStart, accessTimeEnd);
        rules.Add(rule);
    }

    public void RemoveRule(Rule rule) => rules.Remove(rule);

    public Area? GetLocation() => location?.Copy();

    public void SwitchLocation(Area area) => location = location is null ? area : null;
}
