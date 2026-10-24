class Staff
{
    public string Name { get; set; }
    public string Position { get; set; }
    private Area? location;

    public Staff(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public Area? GetLocation() => location?.Copy();

    public void SwitchLocation(Area area) => location = location is null ? area : null;
}
