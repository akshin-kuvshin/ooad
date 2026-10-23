class Card : Key
{
    private static int nextID = 0;

    public readonly int ID;

    public Card(Staff owner) : base(owner)
    {
        ID = nextID++;
    }
}
