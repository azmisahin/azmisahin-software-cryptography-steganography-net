using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace CryptoSteganography.Extensions.Json
{
    /// <summary>
    /// Json Extension
    /// </summary>
    public static class Attribute
    {
        /// <summary>
        /// To String Array
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string[] ToStringArray(this string value)
        {
            return JsonConvert.DeserializeObject<string[]>(value, Converter.Settings);
        }
    }

    /// <summary>
    /// Converter
    /// </summary>
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}