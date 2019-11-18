using System.Drawing;

namespace CryptoSteganography.Extensions.Picture.Tests.Mock
{
    public static class PictureMock
    {
        public readonly static byte[] SampleColorByteArray = new byte[4] { 255, 254, 253, 252 };
        public readonly static Color SampleColor = Color.FromArgb(alpha: 255, red: 254, green: 253, blue: 252);
        public readonly static Color SampleMergedColor = Color.FromArgb(alpha: 253, red: 252, green: 252, blue: 253);
        public readonly static int SampleInt = 19;
        public readonly static Color SampleIntMerger = Color.FromArgb(252, 253, 252, 255);
    }
}
