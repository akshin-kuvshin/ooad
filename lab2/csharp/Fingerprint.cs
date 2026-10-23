class Fingerprint : Key
{
    public readonly string Hash;

    public Fingerprint(Staff owner, string hash) : base(owner)
    {
        Hash = hash;
    }
}
