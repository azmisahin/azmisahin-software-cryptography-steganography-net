namespace CryptoSteganography.Extensions.Int.Tests.Mock
{
    /// <summary>
    /// Int Mock Const
    /// </summary>
    public static class IntMock
    {
        public static readonly int IntItem = 65;
        public static readonly int[] IntArray = new int[] { 0, 1, 0, 0, 0, 0, 0, 1 };
        public static readonly byte ByteItem = 65;
        public static readonly int[,] IntMatrix = new int[4, 8]
        {
            { 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1, 1, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 0, 0 }
        };
        public static readonly byte[] ByteArray = new byte[4] { 255, 254, 253, 252 };
    }
}
