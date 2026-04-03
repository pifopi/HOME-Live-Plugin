namespace HomeLive.DeviceExecutor;

public static class HomeDataOffsets
{
    public const string HomeTitleID = "010015F008C54000";
    public const string HomeSupportedVersion = "4.0.0";

    public const int HomeSlotSize       = 0x330;
    public const int HomeSlotCount      = 30;
    public const int HomeBoxCount       = 200;
    public const int HeaderLength       = 0x10;
    public const int SeedOffset         = 0x02;
    public const int EncSizeOffset      = 0x0E;

    public const uint BoxStartOffset = 0x4C0130; //Heap
    //public static IReadOnlyList<long> BoxStartPointer { get; } = [0x8D6E78, 0x08, 0x58];

    public static ulong GetBoxOffset(ulong startOffset, int box) => startOffset + (ulong)(HomeSlotSize * HomeSlotCount * box);
    public static ulong GetSlotOffset(ulong startOffset, int box, int slot) => GetBoxOffset(startOffset, box) + (uint)(HomeSlotSize * slot);
}