abstract class Key
{
    public readonly Staff Owner;
    private List<Rule> rules = new();

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
}
