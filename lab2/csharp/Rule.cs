class Rule
{
    private Area area;
    private List<TimeOnly?> accessTimeStart;
    private List<TimeOnly?> accessTimeEnd;

    public Rule(Area area, List<TimeOnly?> accessTimeStart, List<TimeOnly?> accessTimeEnd)
    {
        if (accessTimeStart.Count != 7)
            throw new ArgumentException($"accessTimeStart must contains exactly 7 elements; given: {accessTimeStart.Count} elements");
        if (accessTimeEnd.Count != 7)
            throw new ArgumentException($"accessTimeEnd must contains exactly 7 elements; given: {accessTimeEnd.Count} elements");

        for (int i = 0; i < 7; ++i)
        {
            if (accessTimeStart[i] is null && accessTimeEnd[i] is not null)
                throw new ArgumentException($"For each i=0..6 accessTimeStart[i] must be either null or not null simultaneously;\nGiven: accessTimeStart[{i}] is null and accessTimeEnd[{i}] is not null");
            if (accessTimeStart[i] is not null && accessTimeEnd[i] is null)
                throw new ArgumentException($"For each i=0..6 accessTimeStart[i] must be either null or not null simultaneously;\nGiven: accessTimeStart[{i}] is not null and accessTimeEnd[{i}] is null");
            if (accessTimeStart[i] > accessTimeEnd[i])
                throw new ArgumentException($"For each i=0..6 accessTimeStart[i] must be less or equal to accessTimeEnd[i];\nGiven: accessTimeStart[{i}] = {accessTimeStart[i]} > {accessTimeEnd[i]} = accessTimeEnd[{i}]");
        }

        this.area = area;
        this.accessTimeStart = accessTimeStart;
        this.accessTimeEnd = accessTimeEnd;
    }

    public bool Allows(Area area, int dayOfWeek, TimeOnly timeOnly)
    {
        if (dayOfWeek is not (>= 0 and < 7))
            throw new ArgumentException($"dayOfWeek must be in range [0; 7); given: {dayOfWeek}");

        var areaMatches = this.area.Equals(area);
        var timeMatches = accessTimeStart[dayOfWeek] <= timeOnly && timeOnly <= accessTimeEnd[dayOfWeek];
        return areaMatches && timeMatches;
    }
}
