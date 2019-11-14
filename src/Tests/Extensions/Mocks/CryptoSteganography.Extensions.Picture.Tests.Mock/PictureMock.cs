using System.Drawing;

namespace CryptoSteganography.Extensions.Picture.Tests.Mock
{
    public static class PictureMock
    {
        public readonly static byte[] SampleColorByteArray = new byte[4] { 255, 254, 253, 252 };
        public readonly static Color SampleColor = Color.FromArgb(alpha: 255, red: 254, green: 253, blue: 252);
    }
}
