﻿namespace CryptoSteganography.Extensions.Bit.Tests.Mock
{
    /// <summary>
    /// Bit Mock Const
    /// </summary>
    public class BitMock
    {
        public readonly int BitLength = 8;
        public readonly int[] BitArray = new int[] { 0, 1, 0, 0, 0, 0, 0, 1 };
        public readonly int[,] BitMatrix = new int[4, 8]
        {
            { 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1, 1, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 0, 0 }
        };
        public readonly int[,] StringBitMatrix = new int[19, 8] {
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
        public readonly int[,] MergedBitMatrix = new int[4, 8]
        {
            { 1, 1, 1, 1, 1, 1, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 0, 0 },
            { 1, 1, 1, 1, 1, 1, 0, 0 },
            { 1, 1, 1, 1, 1, 1, 0, 1 }
        };
        public readonly int[,] StringMergedBitMatrix = new int[19, 8] {
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
