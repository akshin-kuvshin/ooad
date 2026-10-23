class Area
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Area(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public Area Copy() => (Area)MemberwiseClone();

    public override bool Equals(object? obj) => obj is Area area && Name == area.Name;

    public override int GetHashCode() => Name.GetHashCode();
}
