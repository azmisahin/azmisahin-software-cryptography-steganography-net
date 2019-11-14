namespace CryptoSteganography.Extensions.Byte.Tests.Mock
{
    /// <summary>
    /// Byte Mock Const
    /// </summary>
    public static class BitMock
    {
        public static readonly byte ByteItem = 65;
        public static readonly byte[] ByteArray = new byte[4] { 255, 254, 253, 252 };
        public static readonly byte[] StringByteArray = new byte[19] { 67, 114, 121, 112, 116, 111, 83, 116, 101, 103, 97, 110, 111, 103, 114, 97, 112, 104, 121 };
        public static readonly byte[] MergedByteArray = new byte[4] { 253, 252, 252, 253 };
    }
}
