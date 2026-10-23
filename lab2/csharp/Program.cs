static class Program
{
    public static void Main(string[] args)
    {
        Staff kolya = new(
            "Nikolay Osipenko",
            "Student"
        );

        Area building2 = new(
            "Building No. 2",
            "36 Lenin Ave., building No. 2, Tomsk, 634050"
        );

        Fingerprint bigFinger = new(
            kolya,
            "KOLYA501"
        );

        TimeOnly sevenAM = new(7, 0),
                 tenPM = new(22, 0);
        bigFinger.EmplaceRule(
            building2,
            [sevenAM, sevenAM, sevenAM, sevenAM, sevenAM, sevenAM, null],
            [tenPM, tenPM, tenPM, tenPM, tenPM, tenPM, null]
        );

        Console.WriteLine("success");
    }
}
