namespace CryptoSteganography.Extensions.Bit.Tests.Mock
{
    /// <summary>
    /// Bit Mock Const
    /// </summary>
    public static class BitMock
    {
        public static readonly int BitLength = 8;
        public static readonly bool[] BoolArray = new bool[] { false, true, false, false, false, false, false, true };
        public static readonly int[] BitArray = new int[] { 0, 1, 0, 0, 0, 0, 0, 1 };
        public static readonly int[,] BitMatrix = new int[4, 8]
        {
            { 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1, 1, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 0, 0 }
        };
        public static readonly int[,] StringBitMatrix = new int[19, 8] {
            { 0, 1, 0, 0, 0, 0, 1, 1 },
            { 0, 1, 1, 1, 0, 0, 1, 0 },
            { 0, 1, 1, 1, 1, 0, 0, 1 },
            { 0, 1, 1, 1, 0, 0, 0, 0 },
            { 0, 1, 1, 1, 0, 1, 0, 0 },
            { 0, 1, 1, 0, 1, 1, 1, 1 },
            { 0, 1, 0, 1, 0, 0, 1, 1 },
            { 0, 1, 1, 1, 0, 1, 0, 0 },
            { 0, 1, 1, 0, 0, 1, 0, 1 },
            { 0, 1, 1, 0, 0, 1, 1, 1 },
            { 0, 1, 1, 0, 0, 0, 0, 1 },
            { 0, 1, 1, 0, 1, 1, 1, 0 },
            { 0, 1, 1, 0, 1, 1, 1, 1 },
            { 0, 1, 1, 0, 0, 1, 1, 1 },
            { 0, 1, 1, 1, 0, 0, 1, 0 },
            { 0, 1, 1, 0, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 0, 0, 0, 0 },
            { 0, 1, 1, 0, 1, 0, 0, 0 },
            { 0, 1, 1, 1, 1, 0, 0, 1 }
        };
        public static readonly int[,] MergedBitMatrix = new int[4, 8]
        {
            { 1, 1, 1, 1, 1, 1, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 0, 0 },
            { 1, 1, 1, 1, 1, 1, 0, 0 },
            { 1, 1, 1, 1, 1, 1, 0, 1 }
        };
        public static readonly int[,] StringMergedBitMatrix = new int[19, 8] {
            { 0, 1, 0, 0, 0, 0, 1, 0 },
            { 0, 1, 1, 1, 0, 0, 1, 1 },
            { 0, 1, 1, 1, 1, 0, 0, 0 },
            { 0, 1, 1, 1, 0, 0, 0, 0 },
            { 0, 1, 1, 1, 0, 1, 0, 0 },
            { 0, 1, 1, 0, 1, 1, 1, 0 },
            { 0, 1, 0, 1, 0, 0, 1, 0 },
            { 0, 1, 1, 1, 0, 1, 0, 1 },
            { 0, 1, 1, 0, 0, 1, 0, 1 },
            { 0, 1, 1, 0, 0, 1, 1, 1 },
            { 0, 1, 1, 0, 0, 0, 0, 1 },
            { 0, 1, 1, 0, 1, 1, 1, 0 },
            { 0, 1, 1, 0, 1, 1, 1, 1 },
            { 0, 1, 1, 0, 0, 1, 1, 1 },
            { 0, 1, 1, 1, 0, 0, 1, 0 },
            { 0, 1, 1, 0, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 0, 0, 0, 0 },
            { 0, 1, 1, 0, 1, 0, 0, 0 },
            { 0, 1, 1, 1, 1, 0, 0, 1 }
        };
    }
}
